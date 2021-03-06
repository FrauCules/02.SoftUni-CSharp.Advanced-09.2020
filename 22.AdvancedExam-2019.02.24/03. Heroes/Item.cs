﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            Strength = strength;
            Ability = ability;
            Intelligence = intelligence;
        }

        public int Strength { get; set; }
        public int Ability { get; set; }
        public int Intelligence { get; set; }

        public override string ToString()
        {
            StringBuilder sbItem = new StringBuilder();

            sbItem.AppendLine("Item:");
            sbItem.AppendLine($"  * Strength: {Strength}");
            sbItem.AppendLine($"  * Ability {Ability}");
            sbItem.Append($"  * Intelligence {Intelligence}");

            return sbItem.ToString();
        }
    }
}
