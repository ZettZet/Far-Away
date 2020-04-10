using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far_Away
{
    class EntityObject : GObject
    {
    }

    class Creature : EntityObject
    {

    }

    class Player : Creature, IControl
    {

    }

    class NPC : Creature
    {

    }

    class Item : EntityObject
    {

    }

    class Weapon : Item, IWearable
    {

    }

    class Armor : Item, IWearable
    {

    }
}
