using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVM
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class ViewModel
        {
            // Bindable property will be created from this property.
            public virtual string Title { get; set; } = "tesatatat";
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Set type of POCO-ViewModel
            mvvmContext1.ViewModelType = typeof(ViewModel);
            // Data binding for the Title property (via MVVMContext API)
            mvvmContext1.SetBinding(textEdit1, c => c.EditValue, "Title");
            // UI binding for the Report command
            ViewModel viewModel = mvvmContext1.GetViewModel<ViewModel>();
            simpleButton2.Click += (s, ee) => XtraMessageBox.Show(viewModel.GetTitleAsHumanReadableString());
        }
    }
}
