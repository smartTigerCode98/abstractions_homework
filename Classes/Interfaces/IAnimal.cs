namespace Classes.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Color { get; set; }

        string Voice();

    }
}