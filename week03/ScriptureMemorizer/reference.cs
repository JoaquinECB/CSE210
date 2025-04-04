using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse; // Nullable for single verses

    // Constructor for a single verse (e.g., "John 3:16")
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    // Constructor for a verse range (e.g., "Proverbs 3:5-6")
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Method to return the reference as a string
    public string GetReference()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}