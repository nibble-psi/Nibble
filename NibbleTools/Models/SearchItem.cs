namespace NibbleTools.Models;

public class SearchItem
{
    public string Title
    {
        get;
    }

    public string PageKey
    {
        get;
    }

    public SearchItem(string title, string pageKey)
    {
        Title = title;
        PageKey = pageKey;
    }

    public override string ToString()
    {
        return Title;
    }
}