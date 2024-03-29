﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrie.DAL;

namespace Geometrie.BLL
{
    public class Point_Depot
    {
        Point_DAL_Depot depot = new Point_DAL_Depot();

        //une méthode pour récupérer un point par son ID
        public Point GetById(int id)
        {
            var p_DAL = depot.GetById(id);
            if (p_DAL == null)
                throw new Exception("Point innexistant");
            return new Point(p_DAL.Id, p_DAL.X, p_DAL.Y);
        }
    }
}
