using LINQ;
List<Auto> autok = new List<Auto>();
if (File.Exists("autok.txt"))
{
    foreach (string sor in File.ReadAllLines("autok.txt"))
    {
        if (!string.IsNullOrWhiteSpace(sor))
        {
            Auto auto = new Auto(sor);
            autok.Add(auto);
            Console.WriteLine(auto);
        }
    }
}
int osszKm = autok.Sum(a => a.FutottKm);
double atlagDij = autok.Average(a => a.NapiDij);
int minKm = autok.Min(a => a.FutottKm);
int maxBerlet = autok.Max(a => a.NapiDij);
int teherDB = autok.Count(a => a.KategoriaEgyezik("teherautó"));
int DB2 = autok.Count(a => a.Kategoria == "Teherautó");
bool VanOlcso = autok.Any(a => a.NapiDij < 10000);

Console.WriteLine($"Összes megtett kilométer:{osszKm}km");
Console.WriteLine($"Átlagos napi bérleti díj: {atlagDij:N0}ft");
Console.WriteLine($"Legkevesebb futott kilométer: {minKm}km"); 
Console.WriteLine($"Legmagasabb napi bérleti díj:{maxBerlet} ft");
Console.WriteLine($"Teherautók száma a flottában: {teherDB} db");
Console.WriteLine($"Van 10 000 Ft alatti napi díjú autó? {(VanOlcso ? "Igen" : "Nem")}");