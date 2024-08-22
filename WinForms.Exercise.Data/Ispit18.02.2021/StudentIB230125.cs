﻿namespace WinForms.Exercise.Data.Ispit18._02._2021
{
    public class StudentIB230125
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
        public int GodinaStudija { get; set; }
        public Spol Spol { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
