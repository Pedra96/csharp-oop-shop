/*Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
Un prodotto è caratterizzato da:
codice (numero intero)
nome
descrizione
prezzo
iva
Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci con loro per testare tutti i metodi che avete previsto e implementato.*/


using CSharpShop;
using System.Linq.Expressions;




Prodotto_Classe prodotto = new Prodotto_Classe("banana",5,4,"casco di banane molto buone e radioattive");


prodotto.StampaProdottoASchermo();