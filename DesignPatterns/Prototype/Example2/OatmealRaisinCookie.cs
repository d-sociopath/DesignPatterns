namespace DesignPatterns.Prototype.Example2
{
    public class OatmealRaisinCookie : Cookie
    {
        public int RaisinCount { get; set; }

        public OatmealRaisinCookie(string flavor, bool hasNuts, int raisinCount)
        {
            Flavor = flavor;
            HasNuts = hasNuts;
            RaisinCount = raisinCount;
        }

        public override Cookie Clone()
        {
            return (Cookie)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Oatmeal Raisin Cookie - Flavor: {Flavor}, Has Nuts: {HasNuts}, Raisin Count: {RaisinCount}";
        }
    }
}
