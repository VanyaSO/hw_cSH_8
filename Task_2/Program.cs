namespace Task_2;

// Створіть додаток «Англо-французький словник», який має
// зберігати наступну інформацію:
//  слово англійською мовою;
//  варіанти перекладу французькою.
// Для зберігання інформації використовуйте Dictionary<T>.
// Додаток має надавати таку функціональність:
//  додати слово і варіанти перекладу;
//  видалити слово;
//  видалити варіанти перекладу;
//  зміна слова;
//  зміна варіанта перекладу;
//  пошук перекладу слова.

class Program
{
    static void Main(string[] args)
    {
        DictionaryCust EngRu = new DictionaryCust("Eng", "Ru");
        
        //  додати слово і варіанти перекладу;
        EngRu.AddWord("apple", "яблоко");
        EngRu.AddWord("banana", "банан");
        EngRu.AddWord("orange", "апельсин");
        EngRu.AddWord("car", "машина");
        EngRu.AddWord("house", "дом");
        Console.WriteLine(EngRu);

        //  видалити слово;
        EngRu.RemoveWord("apple");

        //  видалити варіанти перекладу;
        EngRu.RemoveTranslation("banana");

        //  зміна слова;
        EngRu.ChangeWord("car", "transport");

        //  зміна варіанта перекладу;
        EngRu.ChangeTranslation("transport", "транспорт");

        //  пошук перекладу слова.
        Console.WriteLine(EngRu.GetTranslation("house"));
        
        Console.WriteLine();
        Console.WriteLine(EngRu);

    }
}