using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp_RadSaViseKlasa
{
    public partial class FormStudenti : Form
    {
        public FormStudenti()
        {
            InitializeComponent();
        }
        // klik na dugme "Dodaj novog studenta"
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            // kreiranje nove forme tipa FormUnosNovogStudenta
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();
            DialogResult rez = frm.ShowDialog();
            // unos novog studenta u listBox
            if (rez == System.Windows.Forms.DialogResult.OK)
                listBoxStudenti.Items.Add(frm.Student1.ToString());
        }
        // klik na dugme "Obrisi sve studente"
        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }
        // klik na dugme "Obrisi studenta"
        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            // brisanje selektovanog reda iz listBox-a
            if (!(listBoxStudenti.SelectedIndex < 0))
                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
        }
    }
}
