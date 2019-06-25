using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Register_LoginControl : UserControl
    {
        public Register_LoginControl()
        {
            InitializeComponent();
        }

        #region ButtonCloseForm event things for C# 3.0
        public event EventHandler<ButtonCloseFormEventArgs> ButtonCloseForm;

        protected virtual void OnButtonCloseForm(ButtonCloseFormEventArgs e)
        {
            if (ButtonCloseForm != null)
                ButtonCloseForm(this, e);
        }

        private ButtonCloseFormEventArgs OnButtonCloseForm()
        {
            ButtonCloseFormEventArgs args = new ButtonCloseFormEventArgs();
            OnButtonCloseForm(args);

            return args;
        }

        /*private ButtonCloseFormEventArgs OnButtonCloseFormForOut()
        {
            ButtonCloseFormEventArgs args = new ButtonCloseFormEventArgs();
            OnButtonCloseForm(args);

            return args;
        }*/

        public class ButtonCloseFormEventArgs : EventArgs
        {


            /*public ButtonCloseFormEventArgs()
            {
            }

            public ButtonCloseFormEventArgs()
            {

            }*/
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            OnButtonCloseForm();
        }
    }
}
