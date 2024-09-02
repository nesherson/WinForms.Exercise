using WinForms.Exercise.Data.Ispit01._02._2024;

namespace WinForms.Exercise.Data.Ispit22._02._2024
{
    public class NastavaIB230003
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public ProstorijaIB230003 Prostorija { get; set; }
        public int PredmetId { get; set; }
        public PredmetIB230003 Predmet { get; set; }
        public string Vrijeme { get; set; }
        public string DanOdrzavanja { get; set; }
        public string Oznaka { get; set; }

        public List<PrisustvoIB230003> PrisustvoIB230003 { get; set; }

        public override string ToString()
        {
            return Oznaka;
        }
    }
}