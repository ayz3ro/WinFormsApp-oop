public class StampCatalog
{
    private Dictionary<string, Stamp> stamps = new Dictionary<string, Stamp>();

    // Додати марку
    public bool AddStamp(Stamp stamp)
    {
        if (!stamps.ContainsKey(stamp.Name))
        {
            stamps[stamp.Name] = stamp;
            return true;
        }
        return false; // Марка з такою назвою вже існує
    }

    // Видалити марку
    public bool RemoveStamp(string name)
    {
        return stamps.Remove(name);
    }

    // Редагувати марку
    public bool EditStamp(string name, Stamp updatedStamp)
    {
        if (stamps.ContainsKey(name))
        {
            stamps[name] = updatedStamp;
            return true;
        }
        return false;
    }

    // Пошук марки
    public List<Stamp> FindStamps(
    string? name = null,
    string? country = null,
    decimal? nominalValue = null,
    int? year = null,
    int? circulation = null,
    string? feature = null)
    {
        return stamps.Values.Where(s =>
            (string.IsNullOrEmpty(name) || s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(country) || s.Country.Equals(country, StringComparison.OrdinalIgnoreCase)) &&
            (!nominalValue.HasValue || s.NominalValue == nominalValue.Value) &&
            (!year.HasValue || s.Year == year.Value) &&
            (!circulation.HasValue || s.Circulation == circulation.Value) &&
            (string.IsNullOrEmpty(feature) || s.Features.Contains(feature, StringComparison.OrdinalIgnoreCase))
        ).ToList();
    }
}