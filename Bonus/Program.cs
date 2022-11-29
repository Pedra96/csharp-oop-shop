/*BONUS:
create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
Usando una List, dichiarate una lista dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio.
Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.*/


using Bonus;

var prodotto1 = new Prodotto("Banana",5,4,"bananane molto buone");
var prodotto2 = new Prodotto("Pomodori", 4.3, 4, "pomodori belli rossi");
var prodotto3 = new Prodotto("Gelato", 10.40, 10,"Gelato al fior di latte");

var Wallmart=new List<Prodotto>() { prodotto1,prodotto2,prodotto3};

foreach(var articolo in Wallmart) {
    articolo.StampaProdottoASchermo();
}
