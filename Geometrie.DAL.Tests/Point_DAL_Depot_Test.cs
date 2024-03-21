using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Geometrie.DAL.Tests
{
    public class Point_DAL_Depot_Tests
    {
        [Fact]
        public void Point_DAL_Depot_GetById()
        {
            // Arrange
            Point_DAL_Depot depot = new Point_DAL_Depot();
            Point_DAL p = new Point_DAL(1, 2);
            p = depot.Insert(p);

            // Act
            Point_DAL? p2 = depot.GetById(p.Id.Value); // on cherche un point avce son ID

            // Assert
            Assert.NotNull(p2);
            Assert.Equal(p.Id, p2.Id);
            Assert.Equal(p.X, p2.X);
            Assert.Equal(p.Y, p2.Y);
        }

        [Fact]
        public void Point_DAL_Depot_GetAll()
        {
            // Arrange
            Point_DAL_Depot depot = new Point_DAL_Depot();
            Point_DAL p1 = new Point_DAL(1, 2);
            Point_DAL p2 = new Point_DAL(2, 3);
            Point_DAL p3 = new Point_DAL(3, 4);
            p1 = depot.Insert(p1);
            p2 = depot.Insert(p2);
            p3 = depot.Insert(p3);

            // Act
            IEnumerable<Point_DAL> points = depot.GetAll(); // on affiche tout les points

            // Assert
            Assert.NotNull(points);
            Assert.Contains(points, p => p.Id == p1.Id);
            Assert.Contains(points, p => p.Id == p2.Id);
            Assert.Contains(points, p => p.Id == p3.Id);
        }

        [Fact]
        public void Point_DAL_Depot_Insert()
        {
            // Arrange
            Point_DAL_Depot depot = new Point_DAL_Depot();
            Point_DAL p = new Point_DAL(5, 6);

            // Act
            Point_DAL insertedPoint = depot.Insert(p); //on insert le point p soit (5, 6)

            // Assert
            Assert.NotNull(insertedPoint);
            Assert.NotEqual(0, insertedPoint.Id);
            Assert.Equal(p.X, insertedPoint.X);
            Assert.Equal(p.Y, insertedPoint.Y);

        }

        [Fact]
        public void Point_DAL_Depot_Update()
        {
            // Arrange
            Point_DAL_Depot depot = new Point_DAL_Depot();
            Point_DAL p = new Point_DAL(7, 8);
            p = depot.Insert(p);

            // Modify the point
            p.X = 9;
            p.Y = 10;

            // Act
            Point_DAL updatedPoint = depot.Update(p); // on midifie le point avec les nouvelles infos

            // Assert
            Assert.NotNull(updatedPoint);
            Assert.Equal(p.Id, updatedPoint.Id);
            Assert.Equal(p.X, updatedPoint.X);
            Assert.Equal(p.Y, updatedPoint.Y);

        }

        [Fact]
        public void Point_DAL_Depot_Delete()
        {
            // Arrange
            Point_DAL_Depot depot = new Point_DAL_Depot();
            Point_DAL p = new Point_DAL(11, 12);
            p = depot.Insert(p);

            // Act
            depot.Delete(p); // on supprime le point "p"

            // Assert
            Point_DAL deletedPoint = depot.GetById(p.Id.Value);
            Assert.Null(deletedPoint);
        }
    }
}