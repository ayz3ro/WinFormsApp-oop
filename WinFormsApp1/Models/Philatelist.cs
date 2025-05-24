public class Philatelist
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string ContactInfo { get; set; }
    public bool HasRareStamps { get; set; }
    public List<Stamp> Collection { get; set; }

    public Philatelist(string name, string country, string contactInfo, bool hasRareStamps, List<Stamp> collection)
    {
        Name = name;
        Country = country;
        ContactInfo = contactInfo;
        HasRareStamps = hasRareStamps;
        Collection = collection ?? new List<Stamp>();
    }

    public override string ToString()
    {
        string collectionInfo = Collection.Any()
            ? string.Join(", ", Collection.Select(stamp => stamp.Name))
            : "Колекція порожня.";

        return $"Ім'я: {Name}, Країна: {Country}, Контакти: {ContactInfo}, " +
               $"Рідкісні марки: {(HasRareStamps ? "так" : "ні")}, Колекція: {collectionInfo}";
    }
}