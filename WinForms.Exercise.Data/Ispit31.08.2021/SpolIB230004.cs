﻿namespace WinForms.Exercise.Data.Ispit31._08._2021
{
    public class SpolIB230004
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}