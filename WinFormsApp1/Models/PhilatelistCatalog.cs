public class PhilatelistCatalog
{
    private Dictionary<string, Philatelist> philatelists = new Dictionary<string, Philatelist>();

    // Додати філателіста
    public bool AddPhilatelist(Philatelist philatelist)
    {
        if (!philatelists.ContainsKey(philatelist.Name))
        {
            philatelists[philatelist.Name] = philatelist;
            return true;
        }
        return false; // Ім'я вже існує
    }

    // Видалити філателіста
    public bool RemovePhilatelist(string name)
    {
        return philatelists.Remove(name);
    }

    // Редагувати філателіста
    public bool EditPhilatelist(string name, Philatelist updatedPhilatelist)
    {
        if (philatelists.ContainsKey(name))
        {
            philatelists[name] = updatedPhilatelist;
            return true;
        }
        return false;
    }

    // Пошук філателістів
    public List<Philatelist> FindPhilatelists(
        string? name = null,
        string? country = null,
        string? contactInfo = null,
        bool? hasRareStamps = null)
    {
        return philatelists.Values.Where(p =>
            (string.IsNullOrEmpty(name) || p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(country) || p.Country.Equals(country, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(contactInfo) || p.ContactInfo.Contains(contactInfo, StringComparison.OrdinalIgnoreCase)) &&
            (!hasRareStamps.HasValue || p.HasRareStamps == hasRareStamps.Value)
        ).ToList();
    }
}