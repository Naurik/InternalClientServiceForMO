using System.IO.Compression;

namespace Service.Helpers.Utils{ 

	public static class Archiving {

		//Реализаци сжатия данных
		public static byte[] Compress(byte[] data){
			using (var compressedStream = new MemoryStream())
				using (var zipStream = new GZipStream(compressedStream, CompressionMode.Compress)){
					zipStream.Write(data, 0, data.Length);
					zipStream.Close();
					return compressedStream.ToArray();
				}
		}

		//Распаковка сжатых данных
		public static byte[] Decompress(byte[] data){
			using (var compressedStream = new MemoryStream(data))
				using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
					using (var resultStream = new MemoryStream()){
						zipStream.CopyTo(resultStream);
						return resultStream.ToArray();
					}
		}
	}
}
