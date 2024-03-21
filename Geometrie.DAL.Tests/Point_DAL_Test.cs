namespace Geometrie.DAL.Tests
{
    public class Point_DAL_Test
    {
        /*
         *  Sur les tests unitaires, 3 étapes :
         *  SEA : Setup, Execution, Assert
         *  ou AAA : Arrange, Act, Assert
         */
        [Fact]
        public void Point_DAL_Constructor_sans_id()
        {
            //Arange
            int x = 1;
            int y = 2;

            //Act
            Point_DAL point = new Point_DAL(x, y);

            //Assert
            Assert.NotNull(point); // Vérifie que l'objet n'est pas null
            Assert.Null(point.Id); // Vérifie que l'Id est null
            Assert.Equal(x, point.X); // Vérifie que x est égal à point.X
            Assert.Equal(y, point.Y); // Vérifie que y est égal à point.Y
        }

        //on fait le même test avec une théorie
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]
        public void Point_DAL_Constructor_sans_id_Theory(int x, int y)
        {
            //Arange

            //Act
            Point_DAL point = new Point_DAL(x, y);

            //Assert
            Assert.NotNull(point); // Vérifie que l'objet n'est pas null
            Assert.Null(point.Id); // Vérifie que l'Id est null
            Assert.Equal(x, point.X); // Vérifie que x est égal à point.X
            Assert.Equal(y, point.Y); // Vérifie que y est égal à point.Y
        }

        //on fait le même test avec un id
        [Fact]
        public void Point_DAL_Constructor_avec_id()
        {
            //Arange
            int id = 1;
            int x = 1;
            int y = 2;

            //Act
            Point_DAL point = new Point_DAL(id, x, y);

            //Assert
            Assert.NotNull(point); // Vérifie que l'objet n'est pas null
            Assert.Equal(id, point.Id); // Vérifie que l'Id est null
            Assert.Equal(x, point.X); // Vérifie que x est égal à point.X
            Assert.Equal(y, point.Y); // Vérifie que y est égal à point.Y
        }
    }
}