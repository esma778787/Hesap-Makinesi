using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5Ödev {
    public partial class Calc : Form {

        public Calc() {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e) {
            lastCalc.Text = "log(sin(PI))";
        }

        private void button_del_Click(object sender, EventArgs e) {
            if (ANS.Text.Length != 0) {
                ANS.Text = ANS.Text.Remove(ANS.Text.Length - 1); 
            }
        }

        private void button_c_Click(object sender, EventArgs e) {
            ANS.Text = "";
        }


        //////////////NUMS
        private void button_0_Click(object sender, EventArgs e) {
            ANS.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e) {
            ANS.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e) {
            ANS.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e) {
            ANS.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e) {
            ANS.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e) {
            ANS.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e) {
            ANS.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e) {
            ANS.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e) {
            ANS.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e) {
            ANS.Text += "9";
        }

        private void button_lp_Click(object sender, EventArgs e) {
            ANS.Text += "(";

        }

        private void button_rp_Click(object sender, EventArgs e) {
            ANS.Text += ")";

        }


        void WriteOperator(char op) {
            int len = ANS.Text.Length;
            if (len > 1) {
                if (ANS.Text.IndexOf(op, len - 2) != len - 1) {
                    ANS.Text += op;
                }
            }
            else if (len == 1) {
                ANS.Text += op;
            }
        }

        private void button_div_Click(object sender, EventArgs e) {
            WriteOperator('/');
        }

        private void button_mul_Click(object sender, EventArgs e) {
            WriteOperator('*');
        }

        private void button_min_Click(object sender, EventArgs e) {
            WriteOperator('-');
        }

        private void button_plus_Click(object sender, EventArgs e) {
            WriteOperator('+');
        }

        private void button_dot_Click(object sender, EventArgs e) {
            WriteOperator('.');
            
        }


        string hesapla() {
            ANS.Text = ANS.Text.Replace(",", ".");
            gecmise_ekle(ANS.Text + "=");
            string value = new DataTable().Compute(ANS.Text, null).ToString();
            return value;
        }

        void cevap_yaz(string cevap) {
            lastCalc.Text = ANS.Text;
            ANS.Text = cevap;
            ANS.Text = ANS.Text.Replace(",", ".");
            gecmise_ekle(ANS.Text + "\r\n");
        }

        private void button_eq_Click(object sender, EventArgs e) {
            cevap_yaz(hesapla());
        }



        void gecmise_ekle(string n) {
            string text = n + "\r\n";
            history.AppendText(text);
        }



        private void button_sin_Click(object sender, EventArgs e) {
            history.Text += "sin";
            double value = double.Parse(hesapla());
            value = Math.Sin((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void button_cos_Click(object sender, EventArgs e) {
            history.Text += "cos";
            double value = double.Parse(hesapla());
            value = Math.Cos((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void button_tan_Click(object sender, EventArgs e) {
            history.Text += "tan";
            double value = double.Parse(hesapla());
            value = Math.Tan((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void button_cot_Click(object sender, EventArgs e) {
            history.Text += "cot";
            double value = double.Parse(hesapla());
            value = 1/Math.Tan((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void square_Click(object sender, EventArgs e) {
            history.Text += "square";
            double value = double.Parse(hesapla());
            value = Math.Pow(value,2);
            cevap_yaz(value.ToString());
        }

        private void button_log_Click(object sender, EventArgs e) {
            history.Text += "log ";
            double value = double.Parse(hesapla());
            value = Math.Log10(value);
            cevap_yaz(value.ToString());
        }

        private void reverse_Click(object sender, EventArgs e) {
            history.Text += "(-1)* ";
            double value = double.Parse(hesapla());
            value = value * (-1);
            cevap_yaz(value.ToString());
        }

        private void button_sinh_Click(object sender, EventArgs e) {
            history.Text += "sinh";
            double value = double.Parse(hesapla());
            value = Math.Sinh((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void button_cosh_Click(object sender, EventArgs e) {
            history.Text += "cosh";
            double value = double.Parse(hesapla());
            value = Math.Cosh((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void button_tanh_Click(object sender, EventArgs e) {
            history.Text += "tanh";
            double value = double.Parse(hesapla());
            value = Math.Tanh((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void button_coth_Click(object sender, EventArgs e) {
            history.Text += "tanh";
            double value = double.Parse(hesapla());
            value = 1/Math.Tanh((Math.PI / 180) * value);
            cevap_yaz(value.ToString());
        }

        private void ANS_TextChanged(object sender, EventArgs e) {

        }
    }
}
