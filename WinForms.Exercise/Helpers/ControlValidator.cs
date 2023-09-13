namespace WinForms.Exercise.Helpers
{
    public class ControlValidator
    {
        public static bool Validate(Control control, ErrorProvider errorProvider, string key)
        {
            var valid = true;
            if (control is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
            {
                valid = false;
                errorProvider.SetError(tb, ResourceGetter.Get(key));
                return valid;
            }
            else if (control is ComboBox cb && cb.SelectedItem == null)
            {
                valid = false;
                errorProvider.SetError(cb, ResourceGetter.Get(key));
                return valid;
            }


            errorProvider.Clear();

            return valid;
        }
    }
}