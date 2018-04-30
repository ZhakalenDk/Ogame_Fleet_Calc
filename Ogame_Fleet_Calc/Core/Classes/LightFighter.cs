using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataContainers.Structs;
using Core.Interfaces;

namespace Core.Classes
{
    /// <summary>
    /// Represents a Light figther object
    /// </summary>
    class LightFighter : IShip
    {
        public string Name { get; set; }
        public Price ShipCost { get; set; }
    }
}
