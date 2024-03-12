using Geometrie.BLL;

var p = new Point(1,2);
Console.WriteLine(p);
// En écriture, ca ne marche pas 
//p.X= 3;
var c = new Cercle(2, p);
Console.WriteLine($"{c} : .{c.CalculerAire()}");

//test du polygone
var p1 = new Point(0,0);
var p2 = new Point(1,0);
var p3 = new Point(1,1);
var p4 = new Point(0,1);
var poly = new Polygone(p1, p2, p3);
Console.WriteLine(poly.CalculerPerimetre());

var listeDeFormes= new List<IForme>();
listeDeFormes.Add(c);
listeDeFormes.Add((IForme)poly);
listeDeFormes.Add(quadri);

foreach (var forme in listeDeFormes)
{
    Console.WriteLine($"{item} ### Périmètre : {item.CalculerPerimetre()} ### Aire : {item.});
}