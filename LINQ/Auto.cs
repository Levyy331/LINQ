namespace LINQ
{
    internal class Auto
    {
        public string Rendszam { get; set; }
        public string Tipus { get; set; }
        public string Kategoria { get; set; }
        public int NapiDij { get; set; }
        public int FutottKm { get; set; }
        public Auto(string sor)
        {
            string[] adatok = sor.Split(';');
            Rendszam = adatok[0];
            Tipus = adatok[1];
            Kategoria = adatok[2];
            NapiDij = int.Parse(adatok[3]);
            FutottKm = int.Parse(adatok[4]);
        }
        public int BerlesDijKalkulator(int napokSzama)
        {
            if (napokSzama >= 7)
            {
                return (int)(NapiDij * napokSzama * 0.9);
            }
            return NapiDij * napokSzama;
        }
        public bool KategoriaEgyezik(string keresettKategoria)
        {
            return Kategoria.ToLower() == keresettKategoria.ToLower();
        }
        public override string ToString()
        {
            return $"[{Rendszam}] {Tipus}({Kategoria}) - Napi díj {NapiDij} ft | Futott km: {FutottKm} km";
        }
    }
}
