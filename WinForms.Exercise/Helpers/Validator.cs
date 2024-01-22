namespace WinForms.Exercise.Helpers
{
    public class Validator
    {
        public static bool ProvjeriUnos(Control kontrola, ErrorProvider errorProvider, string poruka)
        {
            if (kontrola is TextBox tb && string.IsNullOrEmpty(tb.Text))
            {
                errorProvider.SetError(tb, poruka);
                return false;
            }
            else if (kontrola is DateTimePicker dtp && dtp.Value == null)
            {
                errorProvider.SetError(dtp, poruka);
                return false;
            }
            else if (kontrola is ComboBox cb && cb.SelectedIndex < 0)
            {
                errorProvider.SetError(cb, poruka);
                return false;
            }
            else if (kontrola is PictureBox pb && pb.Image == null)
            {
                errorProvider.SetError(pb, poruka);
                return false;
            }

            errorProvider.Clear();

            return true;
        }
    }
}