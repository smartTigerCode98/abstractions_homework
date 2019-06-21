namespace Classes.Interfaces
{
    public interface IPet : IAnimal
    {
        bool IsVaccinated { get; set; }
    }
}