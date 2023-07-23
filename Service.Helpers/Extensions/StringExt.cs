using System.Text;

namespace Service.Helpers.Extensions{

	public static class StringExt{
		/// <summary>
		/// Метод для конвертации строки в формат base64 
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string StringToBase64String(this string str){
			byte[] data = Encoding.UTF8.GetBytes(str);
			return Convert.ToBase64String(data);
		}

	}
}
