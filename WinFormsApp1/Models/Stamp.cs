public class Stamp
{
    public string Name { get; set; }
    public string Country { get; set; }
    public decimal? NominalValue { get; set; }
    public int? Year { get; set; }
    public int? Circulation { get; set; }
    public string Features { get; set; }

    public Stamp(string name, string country, decimal? nominalValue, int? year, int? circulation, string features)
    {
        Name = name;
        Country = country;
        NominalValue = nominalValue;
        Year = year;
        Circulation = circulation;
        Features = features;
    }

    public override string ToString()
    {
        return $"Назва: {Name}, Країна походження: {Country},Номінальна вартість: {NominalValue} грн, Рік випуску: {Year}, Тираж: {Circulation}, Особливості: {Features}";
    }
}