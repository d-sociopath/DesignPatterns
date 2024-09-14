namespace DesignPatterns.Builder.Example1
{
    public interface IHousePlan
    {
        void SetBasement(string basement);
        void SetStructure(string structure);
        void SetRoof(string roof);
        void SetInterior(string interior);
    }
}
