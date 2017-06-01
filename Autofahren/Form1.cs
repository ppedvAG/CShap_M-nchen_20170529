using System;
using System.Drawing;
using System.Windows.Forms;

namespace Autofahren
{
    public partial class Form1 : Form
    {
        private Auto pkw;

        public Form1()
        {
            InitializeComponent();

            pkw = new Auto(50);
            pkw.BackColor = Color.Red;
            pkw.Text = "Pkw";
            SetPkwToStartPosition();
            UpdateFormText();

            StraßePanel.Controls.Add(pkw);
        }

        private void SetPkwToStartPosition()
        {
            pkw.Left = 2;
            pkw.Top = StraßePanel.Height / 2 - pkw.Height / 2;
        }
        private void UpdateFormText()
        {
            Text = $"Geschwindigkeit: {pkw.Geschwindigkeit} km/h";
        }

        private void StartpositionButton_Click(object sender, EventArgs e)
        {
            SetPkwToStartPosition();
        }

        private void LangsamerButton_Click(object sender, EventArgs e)
        {
            pkw.Geschwindigkeit -= 10;
            UpdateFormText();
        }

        private void SchnellerButton_Click(object sender, EventArgs e)
        {
            pkw.Geschwindigkeit += 10;
            UpdateFormText();
        }

        private void BeendenButton_Click(object sender, EventArgs e)
        {
            Close();
            pkw.Geschwindigkeit = Auto.MinGeschwindigkeit;
        }

        private void FahrenButton_Click(object sender, EventArgs e)
        {
            StartpositionButton.Enabled = false;
            FahrenButton.Enabled = false;

            pkw.Fahren(StraßePanel.Width - pkw.Width);

            StartpositionButton.Enabled = true;
            FahrenButton.Enabled = true;
        }
    }
}
