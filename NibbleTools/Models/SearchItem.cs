namespace NibbleTools.Models;

public class SearchItem
{
    public SearchItem(string title, string pageKey)
    {
        Title = title;
        PageKey = pageKey;
    }

    public string Title
    {
        get;
    }

    public string PageKey
    {
        get;
    }

    public override string ToString() => Title;
}