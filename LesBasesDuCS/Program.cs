namespace LesBasesDuCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Commentaires
            /* Commentaires */

            //pour ranger son code, il y a les regions 
            #region Un bloc de code que je veux ranger 
            //code
            //...
            #endregion

            #region Variables
            // en 2 fois : déclaration puis affectation
            int age; // déclaration
            age = 25; // affectation

            //en 1 fois : déclaration et affectation
            int taille = 180;

            //var le type est réduit par le compilateur
            var prenom = "Jean"; 
            #endregion

            #region Opérateurs
            //Opérateurs arithmétiques
            int a = 5;
            int b = 2;
            int c = a + b; // c = 7
            //Opérateurs de comparaison
            bool estEgal = a == b; // estEgal = false
            //Opérateurs logiques
            bool estVrai = true;
            bool estFaux = false;
            bool resultat = estVrai && estFaux; // resultat = false
            #endregion

            #region Tableaux
            //Tableau de 5 entiers
            int[] tableau = new int[5];
            tableau[0] = 1;
            tableau[1] = 2;
            tableau[2] = 3;
            tableau[3] = 4;
            tableau[4] = 5;

            //Version simplifiée
            int[] tableau2 = { 1, 2, 3, 4, 5 };

            //Tableau à 2 dimensions 
            int[,] tableau3 = new int[2, 3];
            tableau3[0, 0] = 1;
            tableau3[0, 1] = 2;
            tableau3[0, 2] = 3;
            tableau3[1, 0] = 4;
            //...

            //tableaux de tableaux
            int[][] tableau4 = new int[2][];
            tableau4[0] = new int[3];
            tableau4[1] = new int[2];
            tableau4[0][0] = 1;
            tableau4[0][1] = 2;
            tableau4[0][2] = 3;
            tableau4[1][0] = 4;
            //...
            #endregion

            #region Structures de contrôle
            //if
            if (age > 18)
            {
                //code
            }
            else if (age == 18)
            {
                //code
            }
            else
            {
                //code
            }

            JoursDeLaSemaine débutDeLaSemaine = JoursDeLaSemaine.Lundi;
            switch (débutDeLaSemaine)
            {
                case JoursDeLaSemaine.Lundi:
                    //code
                    break;
                case JoursDeLaSemaine.Mardi:
                    //code
                    break;
                //...
                default:
                    //code
                    break;
            }

            //boucle for
            for (int i = 0; i < 10; i++)
            {
                //code
            }
            //while
            while (age < 30)
            {
                //code
            }
            //do while
            do
            {
                //code
            } while (age < 30);
            //foreach
            foreach (int valeur in tableau)
            {
                //code
            }

            #endregion

            #region Génériques
            //Liste de chaînes de caractères
            var liste = new List<int>(); //on choisit le type à l'instanciation
            liste.Add(1);
            #endregion

            #region types anonymes
            //on peut créer des types anonymes
            //utiles pour stocker plusieurs valeurs
            //mais du coup pas de typage fort
            var personne = new { Nom = "Dupont", Prénom = "Jean", Age = 25 };
            #endregion
        }
    }
}
