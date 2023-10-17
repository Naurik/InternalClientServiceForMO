using Jose;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using KalkanCryptCOMLib;
using Microsoft.IdentityModel.Protocols.WsSecurity;
using Microsoft.IdentityModel.Tokens;
using Service.Helpers.ResponseModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using _logger = Service.DATA.Logger;

namespace Service.Helpers.Utils{

	public static class Signing{

		//Получение массива батов из строки
		public static byte[] GetBytes(string str){
			byte[] bytes = new byte[str.Length * sizeof(char)];
			System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}

		//Получение строки из массива батов
		public static string GetString(byte[] bytes){
			char[] chars = new char[bytes.Length / sizeof(char)];
			System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
			return new string(chars);
		}

		//Реализаци транспортной подписи
		public static string SignWSSE(RequestModel model, string fileName)
		{
            try 
            {
                var filePath = @"C:\cert\GOSTKNCA_7509e1b080e7cec7bea50387ed2882b29a25d7c5.p12";
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("File not found");
                var pin = "January2024!";
                var kalkanCOM = new KalkanCryptCOM();
                kalkanCOM.Init();
                kalkanCOM.LoadKeyStore((int)KALKANCRYPTCOM_STORETYPE.KCST_PKCS12, pin, filePath, model.Attr);
                kalkanCOM.SignWSSE(model.Attr, 0, model.Xml, model.Attr, out string outSign);
                kalkanCOM.GetLastErrorString(out string err_str, out uint err);
                kalkanCOM.XMLFinalize();
                return outSign == null ? err_str : outSign;
            }
            catch(Exception ex)
            {
                _logger.WriteToFile($"ErrorInnerException : {ex.InnerException}", fileName, _logger.LogLevel.Error);
                _logger.WriteToFile($"ErrorMessage : {ex.Message}", fileName, _logger.LogLevel.Error);
                throw new Exception(ex.Message);
            }
			
		}

        public static string signWsseWithPrentNodeId(string signXML, string attr, string fileName)
        {
            try
            {
                var filePath = @"C:\cert\GOSTKNCA_7509e1b080e7cec7bea50387ed2882b29a25d7c5.p12";
                //var filePath = @"/home/administrator/Documents/cert/GOSTKNCA_e0cf1c56be078742096e3323482650d1b144ef75.p12";
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("File not found");

                string parentSignNode = "";
                string parentNameSpace = "";
                string outSign = "", err_str = "";
                uint err;
                var pin = "January2024!";
                KalkanCryptCOMLib.IKalkanCryptCOM KalkanCOMTest = new KalkanCryptCOMLib.KalkanCryptCOM();
                KalkanCOMTest.Init();
                KalkanCOMTest.LoadKeyStore((int)KALKANCRYPTCOM_STORETYPE.KCST_PKCS12, pin, filePath, "");
                KalkanCOMTest.SignXML("", 0, "", parentSignNode, parentNameSpace, signXML, out outSign);
                KalkanCOMTest.GetLastErrorString(out err_str, out err);
                KalkanCOMTest.XMLFinalize();

                return outSign;
            }
            catch (Exception ex)
            {
                _logger.WriteToFile($"ErrorInnerException : {ex.InnerException}", fileName, _logger.LogLevel.Error);
                _logger.WriteToFile($"ErrorMessage : {ex.Message}", fileName, _logger.LogLevel.Error);
                throw new Exception(ex.Message);
            }
        }

        //Подпись бизнес данных
        public static string SignData(RequestModel model)
        {
            var filePath = @"C:\cert\GOSTKNCA_7509e1b080e7cec7bea50387ed2882b29a25d7c5.p12";
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found");
            var pin = "January2024!";
            var kalkanCOM = new KalkanCryptCOM();
			string outSign = "";
            kalkanCOM.Init();
            kalkanCOM.X509LoadCertificateFromFile(filePath, (int)KalkanCryptCOMLib.KALKANCRYPTCOM_CERTTYPE.KC_CERT_USER);
            kalkanCOM.SignData("", 0, model.Xml, ref outSign);
            kalkanCOM.GetLastErrorString(out string err_str, out uint err);
            kalkanCOM.XMLFinalize();
            return outSign == null ? err_str : outSign;
        }

        public static string VerifyXml(string response)
        {
            var filePath = @"C:\cert\KylyshbekMadi.cer";
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found");
            var pin = "January2024!";
            var kalkanCOM = new KalkanCryptCOM();
            kalkanCOM.Init();
            kalkanCOM.X509LoadCertificateFromFile(filePath, (int)KalkanCryptCOMLib.KALKANCRYPTCOM_CERTTYPE.KC_CERT_USER);
            string outVerifyInfo = " ";
            kalkanCOM.VerifyXML(" ", 0, response, out outVerifyInfo);
            kalkanCOM.Finalize();
			return outVerifyInfo;
        }

        public static T DeserilizeXmlToObject<T>(string xmlStr, string fileName)
		{
			T resp;
			try
			{
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                using (StringReader reader = new StringReader(xmlStr))
                {
                    resp = (T)xmlSerializer.Deserialize(reader)!;
                }
            }
			catch(Exception ex)
			{
                _logger.WriteToFile($"Error = {ex.InnerException}", fileName, _logger.LogLevel.Error);
				throw new Exception(ex.Message);
			}
            
			return resp;
        }

		public static string CreateJwtToken(string fileName)
		{
            try
            {
                string p12FilePath = @"C:\cert\ЭЦП\AUTH_RSA256_85d7d00247d15fa6f8de3f476657140323f18bc1.p12";
                string p12Password = "January2024!";

                //X509Certificate2 certificate = new X509Certificate2(p12FilePath, p12Password);
                //RSA rsa = certificate.GetRSAPrivateKey()!;

                //// Set your secret key for signing the token
                //string secretKey = @"C:\Users\Назия\Downloads\ЭЦП\AUTH_RSA256_32b7eca33c44da530f106b368bb40bdb3577ca23.p12";
                //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
                DateTime now = DateTime.UtcNow;
                DateTime iat = now;
                DateTime exp = now.AddHours(1);

                // Create payload and header for the token
                var headers = new Dictionary<string, object>()
            {
                { "alg", "RS256"},
                { "typ", "JWT" }
            };
                var payload = new Dictionary<string, object>
            {
                { "cbin", "210140026476" },
                { "mcheck", "Ds" },
                { "iat", iat },
                { "exp", exp }
            };


                var privateKey = new X509Certificate2(p12FilePath, p12Password, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.MachineKeySet).PrivateKey as RSACryptoServiceProvider;

                string token = Jose.JWT.Encode(payload, privateKey, JwsAlgorithm.RS256);

                //var signingCredentials = new SigningCredentials(new RsaSecurityKey(rsa), SecurityAlgorithms.RsaSha256);

                //var tokenHandler = new JwtSecurityTokenHandler();
                //var tokenDescriptor = new SecurityTokenDescriptor
                //{
                //    AdditionalHeaderClaims = headers,
                //    Claims = payload,
                //    Subject = new ClaimsIdentity(),
                //    Expires = DateTime.UtcNow.AddHours(1),
                //    SigningCredentials = signingCredentials
                //};

                //var token = tokenHandler.CreateToken(tokenDescriptor);
                //string tokenString = tokenHandler.WriteToken(token);
                _logger.WriteToFile($"JWT Token : {token}", fileName, _logger.LogLevel.Information);
                //Console.WriteLine("JWT Token: " + tokenString);
                return token;
            }
            catch(Exception ex)
            {
                _logger.WriteToFile("Don't create JWT Token", fileName, _logger.LogLevel.Error);
                throw new Exception(ex.Message);
            }
        }

        public static bool ValidateJwtToken(string secretKey, string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero // Optional: Set clock skew to zero to check token expiration more precisely
            };

            try
            {
                ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                _logger.WriteToFileDefault("Token is valid.", _logger.LogLevel.Information);
                return true;
            }
            catch (Exception ex)
            {
                _logger.WriteToFileDefault("Token validation failed: " + ex.Message, _logger.LogLevel.Information);
                return false;
            }
        }

        public static int GetTag(string tagName, string xml)
        {
            try
            {
                XmlDocument docXML = new XmlDocument();
                docXML.Load(xml);
                var tag = docXML.GetElementsByTagName(tagName);

                if (tag.Count==0)
                {
                    return 0;
                }
                return 1;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
	}
}
