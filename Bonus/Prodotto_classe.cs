using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bonus {
    public class Prodotto {

        private string codice;
        private string Nome;
        private string descrizione;
        private double prezzo;
        private float iva;
        public Prodotto(string nome, double prezzo, float iva, string descrizione = "") {
            this.codice = this.SetCodice();
            this.Nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public void SetNome(string nome) {
            this.Nome = nome;
        }
        public string GetNome() {
            return this.Nome;
        }
        public void SetDescrizione(string descrizione) {
            this.descrizione = descrizione;
        }
        public string GetDescrizione() {
            return this.descrizione;
        }
        public double CalcoloPrezzoConIva() {
            float iva = this.GetIva();
            double prezzo = this.GetPrezzo();
            return Math.Round(prezzo + ((prezzo * iva) / 100),2);
        }
        public void SetPrezzo(double prezzo) {
            Math.Round(prezzo, 2);
            this.prezzo = prezzo;
        }
        public double GetPrezzo() {
            return this.prezzo;
        }
        public void SetIva(float iva) {
            Math.Round(iva, 2);
            this.iva = iva;
        }
        public float GetIva() {
            return this.iva;
        }
        private string SetCodice() {
            Random number = new Random();
            string numero = Convert.ToString(number.Next(100000000));
            if (numero.Length < 8) {
                string pad ="";
                for (int i = 0; i < (8 - numero.Length) ; i++) {
                    pad += '0';
                }
            string numeroCompleto = pad + numero;
            return numeroCompleto;
            } else {
                return numero;
            }
            
        }
        public string GetCodice() {
            return this.codice;
        }
        public void StampaProdottoASchermo() {
            Console.WriteLine("------------------");
            Console.WriteLine($"Nome del prodotto: {this.Nome}");
            Console.WriteLine($"Descrizione: {this.descrizione}");
            Console.WriteLine($"prezzo senza iva: {this.prezzo} euro");
            Console.WriteLine($"iva prodotto: {this.iva} %");
            Console.WriteLine($"prezzo con iva: {this.CalcoloPrezzoConIva()} euro");
            Console.WriteLine($"codice prodotto: {this.codice}{this.Nome}");
            Console.WriteLine("------------------");
        }
    }

}
