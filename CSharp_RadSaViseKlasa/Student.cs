using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_RadSaViseKlasa
{
    public class Student
    {
        // deklarisanje privatnih atributa
        private string ime;
        private string prezime;
        private string brojIndeksa;
        private string smer;
        private DateTime datumRodjenja;

        public Student()
        {

        }
        // property za pristup atributu ime
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        // property za pristup atributu prezime
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        // property za pristup atributu brojIndeksa
        public string BrojIndeksa
        {
            get
            {
                return brojIndeksa;
            }
            set
            {
                brojIndeksa = value;
            }
        }
        // property za pristup atributu Smer
        public string Smer
        {
            get
            {
                return smer;
            }
            set
            {
                smer = value;
            }
        }
        // property za pristup atributu datumRodjenja
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                datumRodjenja = value;
            }
        }
        // overridovanje metode ToString()
        public override string ToString()
        {
            return ime + " " + prezime + " " + brojIndeksa + " " + datumRodjenja.ToShortDateString() + " " + smer;
        }
    }
}
