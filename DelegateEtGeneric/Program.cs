using DelegateEtGeneric;

var l = new Liste<int>();
l.Ajouter(5);
l.Ajouter(8);
l.Ajouter(3);

var l2 = new Liste<string>();
l2.Ajouter("toto");
l2.Ajouter("titi");
l2.Ajouter("tata");

foreach (var i in l)
{
    Console.WriteLine(i);
}



foreach (var i = 0; i < l.Count; i++)
{
    Console.WriteLine(l[i]);
}