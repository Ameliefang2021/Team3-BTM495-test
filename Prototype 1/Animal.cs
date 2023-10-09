﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public abstract class Animal
    {
        private int animalID;
        private int age;
        private string sex;
        private string color;
        private string size;

        public int AnimalID
        {
            get { return animalID; }
            set { animalID = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public Animal() { }

        public Animal(int aID, int age, string sx, string co, string si)
        {
            AnimalID = aID;
            Age = age;
            Sex = sx;
            Color = co;
            Size = si;
        }
    }

    
}
