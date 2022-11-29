using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop {
    public class Prodotto_Classe {
        private string codice;
        private string Nome;
        private string descrizione;
        private double prezzo;
        private float iva;



        public void SetNome(string nome) {
            this.Nome = nome;
        }
        public string GetNome() {
            return this.Nome;
        }
        public void SetDescrizione(string descrizione) {
            this.descrizione= descrizione;
        }
        public string GetDescrizione() {
            return this.descrizione;
        }
        public double CalcoloPrezzoConIva() {
            float iva = this.GetIva();
            double prezzo=this.GetPrezzo();
            return prezzo + ((prezzo * iva) / 100);
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
        public void StampaProdottoASchermo() {
            Console.WriteLine("------------------");
            Console.WriteLine($"Nome del prodotto: {this.Nome}");
            Console.WriteLine($"Descrizione: {this.descrizione}");
            Console.WriteLine($"prezzo senza iva: {this.prezzo} euro");
            Console.WriteLine($"prezzo con iva: {this.CalcoloPrezzoConIva()}");
            Console.WriteLine("------------------");
        }
    }

 
}
