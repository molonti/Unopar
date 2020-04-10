using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace SistemaControleEntrega
{
    class VerificaCampos
    {
        public static void ClearControls(Control c)
        {

            foreach (Control Ctrl in c.Controls)
            {
                //Console.WriteLine(Ctrl.GetType().ToString());
                //MessageBox.Show ( (Ctrl.GetType().ToString())) ;
                switch (Ctrl.GetType().ToString())
                {
                    case "System.Windows.Forms.CheckBox":
                        ((CheckBox)Ctrl).Checked = false;
                        break;

                    case "System.Windows.Forms.TextBox":
                        ((TextBox)Ctrl).Text = "";
                        break;

                    case "System.Windows.Forms.RichTextBox":
                        ((RichTextBox)Ctrl).Text = "";
                        break;

                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)Ctrl).SelectedIndex = -1;
                        ((ComboBox)Ctrl).SelectedIndex = -1;
                        break;

                    case "System.Windows.Forms.MaskedTextBox":

                        ((MaskedTextBox)Ctrl).Text = "";
                        break;

                    default:
                        if (Ctrl.Controls.Count > 0)
                            ClearControls(Ctrl);
                        break;

                }

            }
        }
    }
}
