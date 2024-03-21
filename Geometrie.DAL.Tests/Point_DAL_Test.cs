namespace Geometrie.DAL.Tests
{
    public class Point_DAL_Test
    {
        /*
         *  Sur les tests unitaires, 3 �tapes :
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
            Assert.NotNull(point); // V�rifie que l'objet n'est pas null
            Assert.Null(point.Id); // V�rifie que l'Id est null
            Assert.Equal(x, point.X); // V�rifie que x est �gal � point.X
            Assert.Equal(y, point.Y); // V�rifie que y est �gal � point.Y
        }

        //on fait le m�me test avec une th�orie
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
            Assert.NotNull(point); // V�rifie que l'objet n'est pas null
            Assert.Null(point.Id); // V�rifie que l'Id est null
            Assert.Equal(x, point.X); // V�rifie que x est �gal � point.X
            Assert.Equal(y, point.Y); // V�rifie que y est �gal � point.Y
        }

        //on fait le m�me test avec un id
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
            Assert.NotNull(point); // V�rifie que l'objet n'est pas null
            Assert.Equal(id, point.Id); // V�rifie que l'Id est null
            Assert.Equal(x, point.X); // V�rifie que x est �gal � point.X
            Assert.Equal(y, point.Y); // V�rifie que y est �gal � point.Y
        }
    }
}