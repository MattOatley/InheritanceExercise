using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsFriendly = true;
            SkinType = "Feathers";
            Diet = "Omnivore";
            NumLegs = 2;
        }

        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public string FeatherColor { get; set; }
        public bool CanFly { get; set; }
        public string Wings { get; set; }
        public string Beak { get; set; }


    }
    public class Eagle : Bird
    {
        public Eagle()
        {
            FeatherColor = "Black and White";
            CanFly = true;
            Wings = "Large";
            Beak = "Powerful";
        }
    }
}
