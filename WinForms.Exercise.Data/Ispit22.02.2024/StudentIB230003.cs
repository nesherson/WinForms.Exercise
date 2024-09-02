﻿namespace WinForms.Exercise.Data.Ispit01._02._2024
{
    public class StudentIB230003
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string Indeks { get; set; }
        public bool Aktivan { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public byte[]? Slika { get; set; }
        public int SpolId { get; set; }
        public SpolIB230003 Spol { get; set; }

        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

        //public List<PolozeniPredmetIB230002> PolozeniPredmetIB230002 { get; set; }
    }
}