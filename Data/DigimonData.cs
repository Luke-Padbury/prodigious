using Prodigious.Models;

namespace Prodigious.Data
{
    public static class DigimonData
    {
        public static void AddDigimon(Digimon digimon)
        {
            // TO-DO: add validation digimon is valid or maybe implment try catch will be fine

            using (var db = new DigimonDbContext())
            {
                db.Add(digimon);
                db.SaveChanges();
            }
        }
    }
}
