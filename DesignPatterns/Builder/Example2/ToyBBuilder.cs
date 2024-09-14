namespace DesignPatterns.Builder.Example2
{
    public class ToyBBuilder : IToyBuilder
    {
        Toy toy = new Toy();

        public void SetModel()
        {
            toy.Model = "Toy B";
        }

        public void SetHead()
        {
            toy.Head = "1";
        }

        public void SetLimbs()
        {
            toy.Limbs = "2";
        }

        public void SetBody()
        {
            toy.Body = "Steel";
        }

        public void SetLegs()
        {
            toy.Legs = "4";
        }

        public Toy GetToy()
        {
            return toy;
        }
    }
}
