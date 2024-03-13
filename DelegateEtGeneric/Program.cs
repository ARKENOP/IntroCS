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

//déléguer à une méthode anonyme (ancienne syntaxe)
//l.Trier(delegate(int i1, int i2) { return i1 > i2; });
//avec la nouvelle syntaxe exrepssion lambda
l.Trier((i1, i2) => i1 > i2);

foreach (var i = 0; i < l.Count; i++)
{
    Console.WriteLine(l[i]);
}