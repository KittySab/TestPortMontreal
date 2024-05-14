namespace TestPortMontreal.Domain.Arrives
{
    public class Arrivee
    {
        public int Id { get; set; }
        public string? NomNavire { get; set; }
        public DateTime DateArrivee { get; set; }
        public string? PortOrigine { get; set; }
        public string? Terminal { get; set; }
        public string? TypeCargaison { get; set; }
    }
}
