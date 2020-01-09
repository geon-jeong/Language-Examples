using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastColoredTextBoxNS;

namespace WindowsFormsApp1.UserControls
{
    public partial class UCtrl_TextEditor : UserControl
    {
        public FastColoredTextBox FctbEditor { get; set; }

        public UCtrl_TextEditor()
        {
            InitializeComponent();

            // set eiditor
            FctbEditor = new FastColoredTextBox();
            FctbEditor.Dock = DockStyle.Fill;

            // call back function
            FctbEditor.TextChanged += new EventHandler<TextChangedEventArgs>(cb_func_Fctb_TextChanged);
            FctbEditor.KeyPress += new KeyPressEventHandler(this.cb_func_Fctb_KeyPress);
            FctbEditor.KeyUp += new KeyEventHandler(this.cb_func_Fctb_KeyUp);

            this.Controls.Add(FctbEditor);
        }
               
        void cb_func_Fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers("#<", "#>");
        }



        private void cb_func_Fctb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }



        private void cb_func_Fctb_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Alt:
                    break;

                case Keys.Escape:
                    break;

                default:
                    break;

            }

        }
               
    } // end of class
}
