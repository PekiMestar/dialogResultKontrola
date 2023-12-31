﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogResultKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            string poruka = "Odaberite Da / Ne / Odustani";

            string naslov = "Naslovna linija Dijaloga za poruke";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;

            MessageBoxIcon ikona = MessageBoxIcon.Information;

            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);

            switch (rez)

            {

                case DialogResult.Yes:

                    textBoxRezultat.Text = "Izabrali ste botun Da";

                    break;

                case DialogResult.No:

                    textBoxRezultat.Text = "Izabrali ste botun Ne";

                    break;

                case DialogResult.Cancel:

                    textBoxRezultat.Text = "Izabrali ste botun Odustani";

                    break;

            }
        }

        private void textBoxRezultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
