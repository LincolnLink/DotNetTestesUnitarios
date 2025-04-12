namespace FundamentosTestes.Entities
{
    public class Car
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Car(Guid id, string name )
        {
            Id = id;
            Name = name;
        }
    }
}
