namespace Indexers;

public class HttpCookie
{
    // since we are dealing with keyvalue pairs, dictionaries would be best data structure to use
    private readonly Dictionary<string, string> _dictionary;

    // create a constructor to initialize empty dictionary
    public HttpCookie()
    {
        _dictionary = new Dictionary<string, string>();
    }

    // an indexer is created using the this keyword
    public string this[string key]
    {
        get {return _dictionary[key]; }
        set { _dictionary[key] = value; }
    }
    
}