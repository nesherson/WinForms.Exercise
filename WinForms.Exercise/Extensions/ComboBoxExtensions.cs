using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Exercise.Extensions
{
    public static class ComboBoxExtensions
    {
        public static void Load<T>(this ComboBox cb, List<T> dataSource, string valueMember = "Id", string displayMember = "Name")
        {
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
            cb.DataSource = dataSource;
        }
    }
}
