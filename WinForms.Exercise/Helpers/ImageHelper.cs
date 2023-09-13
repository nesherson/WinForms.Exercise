using System.Drawing.Imaging;

namespace WinForms.Exercise.Helpers
{
    public class ImageHelper
    {
        public static Image ToImage(byte[] bytes)
        {
            if (bytes == null) return null;

            return Image.FromStream(new MemoryStream(bytes));
        }

        public static byte[] ToBytes(Image image) 
        {
            if (image == null) return null;

            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
