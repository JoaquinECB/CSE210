using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the display text (hidden or visible)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}