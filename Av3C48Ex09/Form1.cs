using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C48Ex09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                int total = 0;
            if(int.TryParse(textBox1.Text,out total))
                {

                    if (total > 15){  total=(total*10)+180*total        ;}
                    else if(total == 15){ total = (total * 12) + 180 * total; }
                    else if(total < 15){ total = (total * 15) + 180 * total; }
                    MessageBox.Show("Total a pagar: " +total.ToString("C")+"  Para o cliente: "+textBox2.Text);






                }else { MessageBox.Show("Entrada Invalida"); }



            }



            else { MessageBox.Show("Entrada vazia"); }



        }
    }
}
