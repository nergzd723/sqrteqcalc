using System;
using System.Windows.Forms;

namespace sqrteqcalc
{
    public partial class sqrteqsolver : Form
    {
        public sqrteqsolver()
        {
            InitializeComponent();
        }
        private string beyoundzero(double arg)
        {
            if( arg < 0 )
            {
                return "";
            }
            else
            {
                return "+";
            }
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            try
            {
                a = double.Parse(aarg.Text);
                b = double.Parse(barg.Text);
                c = double.Parse(carg.Text);
            }
            catch
            {
                answ.Text = "Bad args";
                aarg.Text = "";
                barg.Text = "";
                carg.Text = "";
            }
            finally
            {
                string bnegative = beyoundzero(b);
                string cnegative = beyoundzero(c);
                string preview = a + "x2 " + bnegative + " " + b + "x " + cnegative + c + " = 0";
                double d = (b * b) - 4 * a * c;
                previewlabel.Text = preview;
                double bneg = b * -1;
                if (d < 0)
                {
                    answ.Text = "x != R";
                }
                else if (d == 0)
                {
                    double x = bneg / 2 * a;
                    answ.Text = "x1 " + " = " + x + "\nx2 =" + x;
                }
                else if (d > 0)
                {
                    double x = (bneg + Math.Sqrt(d)) / 2 * a;
                    double x1 = (bneg - Math.Sqrt(d)) / 2 * a;
                    answ.Text = "x1 =" + x + "\n" + "x2 =" + x1;
                }

            }

        }
    }
}
