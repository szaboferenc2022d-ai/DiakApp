using DiakApp;

List<Diak> diakok = new List<Diak>();
int hibasSorokSzama = 0;

foreach (string sor in File.ReadAllLines("eredmenyek.csv"))
{
    string[] adatok = sor.Split(';');
    if (adatok.Length != 3)
    {
        hibasSorokSzama++;
        continue;
    }
    string nev = adatok[0];
    string osztaly = adatok[1];
    if (!int.TryParse(adatok[2],out int pontszam))
    {
        hibasSorokSzama++;
        continue;
    }
    diakok.Add(new Diak(nev, osztaly, pontszam));

}
