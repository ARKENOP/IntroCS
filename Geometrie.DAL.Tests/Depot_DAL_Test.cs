namespace Geometrie.DAL.Tests
{
    public class Depot_DAL_Test
    {
        // test sur depot_dal
        [Fact]
        public void Depot_DAL_OuvrirConnexion()
        {
            // Arrange
            Depot_DAL<Point_DAL> depot = new Point_DAL_Depot();
            var connexion = new System.Data.SqlClient.SqlConnection();
            var commande = new System.Data.SqlClient.SqlCommand();

            // Act
            depot.OuvrirConnexion(connexion, commande);

            // Assert
            Assert.Equal(connexion, commande.Connection); // vérifie que la connexion est bien la même
            Assert.Equal(System.Data.ConnectionState.Open, connexion.State);
            Assert.Equal(System.Data.ConnectionState.Open, depot.ConnectionState); // vérifie que la connexion est ouverte
        }

        [Fact]
        public void Depot_DAL_FermerConnexion()
        {
            // Arrange
            Depot_DAL<Point_DAL> depot = new Point_DAL_Depot();
            var connexion = new System.Data.SqlClient.SqlConnection();
            var commande = new System.Data.SqlClient.SqlCommand();
            depot.OuvrirConnexion(connexion, commande);

            // Act
            depot.FermerConnexion(connexion, commande);

            // Assert
            Assert.Equal(System.Data.ConnectionState.Closed, connexion.State);
            Assert.Equal(System.Data.ConnectionState.Closed, depot.ConnectionState); // vérifie que la connexion est fermée
        }
    }
}