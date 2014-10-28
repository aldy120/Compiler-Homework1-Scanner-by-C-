using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilerHw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiniteStateMachine.buildStateFunctionTable();
            if (FiniteStateMachine.isAccept(textBox1.Text))
                MessageBox.Show("A Number");
            else
                MessageBox.Show("Not a number");
            textBox1.Focus();
            textBox1.SelectAll();
        }
    }
}
