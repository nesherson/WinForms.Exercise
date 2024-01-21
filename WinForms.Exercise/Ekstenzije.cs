using System.Drawing.Imaging;

namespace WinForms.Exercise
{
    public static class Ekstenzije
    {
        public static void PostaviComboBox<T>(this ComboBox comboBox,
            List<T> dataSource,
            string valueMember = "Id",
            string displayMember = "Oznaka")
        {
            comboBox.ValueMember = valueMember;
            comboBox.DisplayMember = displayMember;
            comboBox.DataSource = dataSource;
        }

        public static Image ToImage(this byte[] bytes) =>
            Image.FromStream(new MemoryStream(bytes));

        public static byte[] ToBytes(this Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}