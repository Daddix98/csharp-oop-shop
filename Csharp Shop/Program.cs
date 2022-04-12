// See https://aka.ms/new-console-template for more information





//------------ CREO OGGETTO 1 ------------//

using Csharp_Shop;
Prodotto mioProdotto = new Prodotto("AirPods", "Cuffie wireless", 129.90, "22%");
mioProdotto.GetGeneraCodiceProdotto();
mioProdotto.GetCalcolaPrezzoIva();
mioProdotto.GetNomeEsteso();
mioProdotto.StampaDati();

//----------- CREO OGETTO 2 ---------//

Prodotto mioProdotto2 = new Prodotto("Beats Studio", "Cuffie con padiglione e con cavo", 250.90, "22%");
mioProdotto2.GetGeneraCodiceProdotto();
mioProdotto2.GetCalcolaPrezzoIva();
mioProdotto2.GetNomeEsteso();
mioProdotto2.StampaDati();