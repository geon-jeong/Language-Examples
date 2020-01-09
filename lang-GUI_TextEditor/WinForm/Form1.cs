using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        UCtrl_TextEditor uc_text_editor = new UCtrl_TextEditor();
        public Form1()
        {
            InitializeComponent();

            uc_text_editor.Dock = DockStyle.Fill;
            this.Controls.Add(uc_text_editor);
        }
    }
}
