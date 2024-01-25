using FIT.Infrastructure;

using System.Drawing.Imaging;

namespace FIT.WinForms.Helpers
{
    public static class Ekstenzije
    {
        public static bool Postavljen(this string sadrzaj)
        {
            return !string.IsNullOrWhiteSpace(sadrzaj);
        }

        public static void UcitajPodatke<T>(this ComboBox comboBox, List<T> dataSource,
            string displayMember = "Naziv", string valueMember = "Id", bool addEmptyField = false)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        public static Image ToImage(this byte[] sadrzaj)
        {            
            var ms = new MemoryStream(sadrzaj);
            return Image.FromStream(ms);
        }
        public static byte[] ToByteArray(this Image sadrzaj)
        {
            var ms = new MemoryStream();
            sadrzaj.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
