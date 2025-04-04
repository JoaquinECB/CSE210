using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Method to get the reference as a string
    public string GetReference()
    {
        return _reference.GetReference();
    }

    // Method to get the scripture text with hidden words
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    // Method to hide random words
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            // Stop if all words are hidden
            if (AllWordsHidden())
            {
                break;
            }
        }
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}