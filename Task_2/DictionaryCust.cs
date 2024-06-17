namespace Task_2;

public class DictionaryCust
{
    private Dictionary<string, string> _languages;
    private Dictionary<string, string> _words;

    public DictionaryCust(string mainLang, string translationLang)
    {
        _languages = new Dictionary<string, string>();
        _languages[mainLang] = translationLang;
        _words = new Dictionary<string, string>();
    }

    public void AddWord(string word, string translation)
    {
        _words.Add(word, translation);
    }
    
    public void RemoveWord(string word)
    {
        _words.Remove(word);
    }
    
    public void RemoveTranslation(string word)
    {
        _words[word] = "";
    }
    
    public void ChangeWord(string oldWord, string newWord)
    {
        string value = _words[oldWord];
        _words.Remove(oldWord);
        _words[newWord] = value;
    }
    
    public void ChangeTranslation(string word, string translation)
    {
        _words[word] = translation;
    }

    public string GetTranslation(string word) => _words[word];

    public override string ToString()
    {
        foreach (KeyValuePair<string, string> keyValue in _words)
        {
            Console.WriteLine($"{_languages.Keys.ElementAt(0)}: {keyValue.Key} - {_languages.Values.ElementAt(0)}: {keyValue.Value}");
        }
        
        return "";
    }
}