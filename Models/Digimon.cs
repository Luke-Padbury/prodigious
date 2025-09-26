namespace Prodigious.Models
{
    public class Digimon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Attribute { get; set; }

        public string Family { get; set; }

        public string Stage { get; set; }

        public List<int> NextForms { get; set; }

        public List<int> PreviousForms { get; set; }
    }
}
