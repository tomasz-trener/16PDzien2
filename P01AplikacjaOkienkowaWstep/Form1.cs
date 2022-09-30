using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaOkienkowaWstep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPowitanie_Click(object sender, EventArgs e)
        {
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
        }

        private void btnPoliczBMI_Click(object sender, EventArgs e)
        {
            if (!WalidujFormatke())
                return;

            int wzrost;

            int waga = Convert.ToInt32(txtWaga.Text);

            wzrost = Convert.ToInt32(txtWzrost.Text);

            // bmi = waga/(wzrost/100)^2

            // double bmi = waga / Math.Pow(Convert.ToDouble(wzrost) / 100, 2);
            //double bmi = waga / Math.Pow(wzrost / 100.0, 2);

            BMIManager mb = new BMIManager();
            double bmi = mb.PoliczBMI(waga, wzrost);

            // bmi = Math.Round(bmi, 2);

            // string wynik = string.Format("{0:0.00}", bmi);
            //
            //txtWynik.Text = Convert.ToString(bmi);

            //string wynik = "BMI osoby, ktora wazy " + waga + " i jej wzrost to " + wzrost +
            //    " wynosi " + string.Format("{0:0.00}", bmi);

            string wynik = string.Format("BMI osoby, która wazy {0} i jej wzrost to {1} wynosi {2:0.00}",
                waga, wzrost, bmi);

            txtWynik.Text = wynik;

            MessageBox.Show(wynik);
        }

        private bool WalidujFormatke()
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(txtWaga.Text))
                sb.AppendLine("Uzupełnij wage");
            if (string.IsNullOrWhiteSpace(txtWzrost.Text))
                sb.AppendLine("Uzupełnij wzrost");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
    }
}