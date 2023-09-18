using System;
using System.Windows.Forms;

namespace FormComplejos_G2_2024_I
{
    public partial class Form1 : Form
    {
        Complejo c1;
        Complejo c2;
        Complejo c3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                if( txtbReal1.Text == ""    )
                {
                    throw new ApplicationException("La parte de real del complejo1 no debe estar vacía");
                }


                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginaria1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginaria2.Text));

                c3 = c1 + c2;
                lbSuma.Text = c3.ToString();
                errorProvider1.Clear();
            }
            catch(ApplicationException error )
            {
                errorProvider1.SetError(txtbReal1, error.Message);
            }

            catch (FormatException error)
            {
                MessageBox.Show("Error: Debes de ingresar un número");
            }

            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        
        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            lbSuma.Text = (~c3).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginaria1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginaria2.Text));

            c3 = c1 * c2;
            lbSuma.Text = c3.ToString();

        }
    }
}
