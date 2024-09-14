using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Example1
{
    public class TipiHouseBuilder : IHouseBuilder
    {
        private House house;

        public TipiHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            house.SetBasement("Wooden Poles");
        }

        public void BuildStructure()
        {
            house.SetStructure("Wood and Ice");
        }

        public void BuildRoof()
        {
            house.SetRoof("Wood");
        }

        public void BuildInterior()
        {
            house.SetInterior("Fire Wood");
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
