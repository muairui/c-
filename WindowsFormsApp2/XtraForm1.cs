using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp2
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public class ViewModel
        {
            // Bindable property will be created from this property.
            public virtual string Title { get; set; }
            // Just a method for readability
            public string GetTitleAsHumanReadableString()
            {
                if (Title == null)
                    return "(Null)";
                if (Title.Length == 0)
                    return "(Empty)";
                if (string.IsNullOrWhiteSpace(Title))
                    return "(WhiteSpace)";
                return Title;
            }
        }
        public XtraForm1()
        {
            InitializeComponent();
        }
    }
}