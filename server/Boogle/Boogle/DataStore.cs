using System;
using System.Collections.Generic;

namespace Boogle
{
    public sealed class DataStore
    {
        private static DataStore instance;

        public List<Banjo> Data { get; set; }

        private DataStore()
        {
            Data = GenerateData();
            Data.ForEach(b => b.Seriennummer = GenerateSerialNumber(b));
        }

        public static DataStore Instance => instance ??= new DataStore();

        private static string GenerateSerialNumber(Banjo banjo)
        {
            return string.Join("-", 
                banjo.Name.Substring(0, 1),
                banjo.Marke.Substring(0, 1),
                Guid.NewGuid());
        }
        
        private static List<Banjo> GenerateData()
        {
            return new List<Banjo>
            {
                new Banjo
                {
                    Name = "Goodtime",
                    Marke = "Deering",
                    Herstellungsland = "USA",
                    Seriennummer = "G-D-b83034f3-ec57-4126-a6d8-45d3e97dcdae"
                },
                new Banjo
                {
                    Name = "Sierra",
                    Marke = "Deering",
                    Herstellungsland = "USA",
                    Seriennummer = "S-D-88b4c96e-1503-460b-acf4-88a011fd7ff1"
                },
                new Banjo
                {
                    Name = "Boston",
                    Marke = "Deering",
                    Herstellungsland = "USA",
                    Seriennummer = "B-D-4ec92951-6654-4833-a2a3-2fc26d12250f"
                },
                new Banjo
                {
                    Name = "Traveler",
                    Marke = "Gold Tone",
                    Herstellungsland = "USA",
                    Seriennummer = "T-G-ec5c0dea-1180-47f8-aa37-639f36655176"
                },
                new Banjo
                {
                    Name = "Plucky",
                    Marke = "Gold Tone",
                    Herstellungsland = "USA",
                    Seriennummer = "P-G-95dbef53-8ec5-4254-b4f0-3a4f6e3f3985"
                },
                new Banjo
                {
                    Name = "Spirit",
                    Marke = "Prucha",
                    Herstellungsland = "Tschechien",
                    Seriennummer = "S-P-ab79d4ed-038e-4cc4-af03-ac06a29f1d16"
                },
                new Banjo
                {
                    Name = "Legend",
                    Marke = "Prucha",
                    Herstellungsland = "Tschechien",
                    Seriennummer = "L-P-21234ecd-48d6-42ee-8638-735ca3bd6078"
                }
            };
        }
    }
}