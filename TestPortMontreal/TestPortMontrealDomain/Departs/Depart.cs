namespace TestPortMontreal.Domain.Departs
{
    public class Depart
    {
        public int Id { get; set; }
        public string? NomNavire { get; set; }
        public DateTime DateDepart { get; set; }
        public string? PortDestination { get; set; }
        public string? Quai { get; set; }
        public string? TypeCargaison { get; set; }
    }
}
