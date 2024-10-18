using SkiaSharp;
using System.IO;
using ZXing;
using ZXing.QrCode;
using ZXing.SkiaSharp;

namespace GoogleUrlAndQrCodeGeneratorLib
{
    public class QrCodeGenerator
    {
        public static  SKBitmap CreateQRCode(string qrCodeContent, int width, int height, int margin)
        {
            BarcodeWriter qrCodeWriter = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = height,
                    Width = width,
                    Margin = margin
                },
            };

            var qrCode = qrCodeWriter.Write(qrCodeContent);

            return qrCode;
        }

        public static byte[] ConvertToBytesArray(SKBitmap bitmap)
        {
            using (var memoryStream = new MemoryStream())
            {
                bitmap.Encode(memoryStream, SKEncodedImageFormat.Png, 80);
                return memoryStream.ToArray();
            }
        }
    }
}
