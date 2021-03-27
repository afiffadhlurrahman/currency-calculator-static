using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;

namespace ConverterUangStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{

                double valCurr = double.Parse(textBox1.Text);
                string fromVal = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                string toVal = comboBox2.Items[comboBox2.SelectedIndex].ToString();
                //if()
                double hasil = 0;
                if(comboBox1.SelectedIndex == 0)
                {
                    // MessageBox.Show(fromVal);
                    // Euro
                    if (comboBox2.SelectedIndex == 0) hasil = valCurr;
                    else if (comboBox2.SelectedIndex == 1) hasil = valCurr * 4.89;
                    else if (comboBox2.SelectedIndex == 2) hasil = valCurr * 1.18;
                    else if (comboBox2.SelectedIndex == 3) hasil = valCurr * 0.356;
                }
                else if(comboBox1.SelectedIndex == 1)
                {
                    // MessageBox.Show(fromVal);
                    // Malaysia - Ringgit
                    if (comboBox2.SelectedIndex == 0) hasil = valCurr * 0.21;
                    else if (comboBox2.SelectedIndex == 1) hasil = valCurr;
                    else if (comboBox2.SelectedIndex == 2) hasil = valCurr * 0.24;
                    else if (comboBox2.SelectedIndex == 3) hasil = valCurr * 0.07;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    // MessageBox.Show(fromVal);
                    // United State - Dollar
                    if (comboBox2.SelectedIndex == 0) hasil = valCurr * 0.8475;
                    else if (comboBox2.SelectedIndex == 1) hasil = valCurr * 4.14;
                    else if (comboBox2.SelectedIndex == 2) hasil = valCurr;
                    else if (comboBox2.SelectedIndex == 3) hasil = valCurr * 0.30;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    // MessageBox.Show(fromVal);
                    // Kuwait - Dinar
                    if (comboBox2.SelectedIndex == 0) hasil = valCurr * 2.81;
                    else if (comboBox2.SelectedIndex == 1) hasil = valCurr * 13.72;
                    else if (comboBox2.SelectedIndex == 2) hasil = valCurr * 3.31;
                    else if (comboBox2.SelectedIndex == 3) hasil = valCurr;
                }
                else
                {
                    MessageBox.Show("GAADA");
                }
                //MessageBox.Show("from : " + fromVal + " to : " + toVal + " " + valCurr);
                MessageBox.Show("HASIL : " + hasil);
                textBox2.Text = hasil.ToString();

            }
            catch (FormatException ex){
                MessageBox.Show("Nilai yang dimasukkan harus integer");
            }
            catch (ArgumentOutOfRangeException ex){
                MessageBox.Show("Currency from harus dipilih");
            }
            catch (Exception ex){
                MessageBox.Show("Error : " + ex);
            }
        }
    }
}
