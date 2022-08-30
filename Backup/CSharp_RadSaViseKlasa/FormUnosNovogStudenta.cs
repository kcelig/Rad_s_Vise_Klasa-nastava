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
    public partial class FormUnosNovogStudenta : Form
    {
        // deklarisanje privatnog atributa tipa Student
        private Student student1;
        // podrazumevani konstruktor
        public FormUnosNovogStudenta()
        {
            InitializeComponent();  
        }
        // property za pristup atributu student1
        public Student Student1
        {
            get 
            { 
                return student1; 
            }
            set 
            { 
                student1 = value; 
            }
        }
        // klik na dugme "Snimi"
        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            // kreiranje novog objekta tipa Student
            student1 = new Student();
            // pristup odgovarajucim atrubutima klase Student
            student1.Ime = textBoxIme.Text;
            student1.Prezime = textBoxPrezime.Text;
            student1.BrojIndeksa = textBoxBrojIndeksa.Text;
            student1.Smer = comboBoxSmer.SelectedItem.ToString();
            student1.DatumRodjenja = dateTimePickerDatumRodjenja.Value;
            DialogResult = DialogResult.OK;
        }
        // klik na dugme "Otkazi"
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
