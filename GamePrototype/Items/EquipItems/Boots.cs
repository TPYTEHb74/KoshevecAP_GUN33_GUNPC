using GamePrototype.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Items.EquipItems
{
    public class Boots : EquipItem
    {
        public Boots(uint maxDurability, string name) : base(maxDurability, name)
        {
        }
        public override EquipSlot Slot { get; }
    }
}