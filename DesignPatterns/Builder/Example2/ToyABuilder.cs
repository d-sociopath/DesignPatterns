﻿namespace DesignPatterns.Builder.Example2
{
    public class ToyABuilder : IToyBuilder
    {
        Toy toy = new Toy();

        public void SetModel()
        {
            toy.Model = "Toy A";
        }

        public void SetHead()
        {
            toy.Head = "1";
        }

        public void SetLimbs()
        {
            toy.Limbs = "4";
        }

        public void SetBody()
        {
            toy.Body = "Plastic";
        }

        public void SetLegs()
        {
            toy.Legs = "2";
        }

        public Toy GetToy()
        {
            return toy;
        }
    }
}
