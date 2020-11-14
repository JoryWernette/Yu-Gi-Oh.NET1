using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Card
    {
        public string Name { get; set; }
        public string Card_category { get; set; } // Monster, Spell, Trap
        public string Card_type { get; set; } // Normal, Effect, Fusion, Field, Equip...
        public string Monster_type { get; set; } // Aqua, Dragon, Spellcaster...
        public string Sub_type { get; set; } // Flip, Gemini, Tuner, Toon, Union...
        public string Attribute { get; set; } // Dark, Light, Wind, Water, Earth, Fire
        public string Level_rank { get; set; }
        public string Attack { get; set; }
        public string Defense { get; set; }
        public string Banlist { get; set; } // Banned, Limited, Semi-Limited, or Unlimited
        public string Card_text { get; set; } // The effect or flavor text of a card
        public string Card_Image_File { get; set; } // the name of the jpg file for the card
        public string Card_Info_File { get; set; } // the txt file that has the cards information 
                                                  // in one spot rather than splitting it all up
                                                 // like i've been trying to do 


    }
}
