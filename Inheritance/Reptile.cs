using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {


        public Reptile()
        {
            IsFriendly = true;
            SkinType = "Scales";
            Diet = "Carnivore";
            NumLegs = 4;

        }
         
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public string Scales { get; set; }
        public string ColdBlooded { get; set; }
        public string Vertebrae { get; set; }
        public string Aquatic { get; set; }


    }

    public class Crocodile : Reptile
    {
        public Crocodile()
        {
            Scales = "Hard and armor like";
            ColdBlooded = "Crocodiles are cold-blooded";
            Vertebrae = "Crocodiles are vertebraes";
            Aquatic = "Crocodiles can swim";
        }
    }
}
