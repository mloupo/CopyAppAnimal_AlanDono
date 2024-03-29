﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrearAnimales.Interfaces;
using CrearAnimales.Model.foodType;

namespace CrearAnimales.Model.dietTypes
{
    internal class Omnivoro : IDiet
    {
        public bool canEat(IFood food) // Esta implementacion va a devolver true si el alimento que recibe por parametro es vegetal o animal 
        {
            return food is VegetalesFood || food is AnimalFood;
        }

        public override string ToString()
        {
            return "Omnivoro";
        }
    }
}
