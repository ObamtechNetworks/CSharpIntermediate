namespace Indexers;

public class HttpCookie(DateTime expiry)
{
    // since we are dealing with keyvalue pairs, dictionaries would be best data structure to use
    private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

    // add expiry property
    public DateTime Expiry { get; private set; } = expiry;

    // Method to update Expiry if needed
    public void SetExpiry(DateTime expiry)
    {
        Expiry = expiry;
    }

    // an indexer is created using the this keyword
    public string this[string key]
    {
        get {return _dictionary[key]; }
        set { _dictionary[key] = value; }
    }
    
}