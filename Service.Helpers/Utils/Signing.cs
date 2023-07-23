using KalkanCryptCOMLib;
using Service.Helpers.Models;

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
		public static string SignWSSE(RequestModel model)
		{
			var filePath = @"C:\cert\GOSTKNCA_e0cf1c56be078742096e3323482650d1b144ef75.p12";
			if (!File.Exists(filePath))
				throw new FileNotFoundException("File not found");
			var pin = "October2030!";
			var kalkanCOM = new KalkanCryptCOM();
			kalkanCOM.Init();
			kalkanCOM.LoadKeyStore((int)KALKANCRYPTCOM_STORETYPE.KCST_PKCS12, pin, filePath, model.Attr);
			kalkanCOM.SignWSSE(model.Attr, 0, model.Xml, model.Attr, out string outSign);
			kalkanCOM.GetLastErrorString(out string err_str, out uint err);
			kalkanCOM.XMLFinalize();
			return outSign == null ? err_str : outSign;
		}

	}
}
