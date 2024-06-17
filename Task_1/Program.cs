namespace Task_1;

// Завдання 1:
// Створіть додаток для менеджменту співробітників та паролів,
// який має зберігати наступну інформацію:
//  логіни співробітників;
//  паролі співробітників.
// Для зберігання інформації використовуйте Dictionary<T>.
// Додаток має надавати таку функціональність:
//  додати логін і пароль співробітника;
//  видалити логін співробітника;
//  змінити інформацію про логін і пароль співробітника;
//  отримати інформацію про пароль за логіном співробітника

class Program
{
    static void Main(string[] args)
    {
        // add
        ManagerEmployee.AddEmployee(new Employee("sasha", "1234"));
        ManagerEmployee.AddEmployee(new Employee("masha", "1234"));

        foreach (var empl in ManagerEmployee.ListEmpls)
        {
            Console.WriteLine(empl);
        }
        
        // delete
        try
        {
            ManagerEmployee.RemoveEmployee("sasha");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();
        foreach (var empl in ManagerEmployee.ListEmpls)
        {
            Console.WriteLine(empl);
        }

        
        // change
        try
        {
            ManagerEmployee.ChangeData("ttt", "alex", "4321");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();
        foreach (var empl in ManagerEmployee.ListEmpls)
        {
            Console.WriteLine(empl);
        }
        
        // get password
        try
        {
            Console.WriteLine(ManagerEmployee.GetPassword("masha"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}