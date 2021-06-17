using QRCoder;
using System.Drawing;


namespace SelfService
{
    class QRManager
    {
        public static string Generate(int allTotal)
        {
            return allTotal.ToString();
        }

        public static string Generate(int allTotal, out Bitmap QrBitmap)
        {
            string text = Generate(allTotal);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QrBitmap = qrCode.GetGraphic(5);

            return text;
        }
    }
}
