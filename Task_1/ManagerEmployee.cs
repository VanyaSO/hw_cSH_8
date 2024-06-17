namespace Task_1;

public static class ManagerEmployee
{
    public static List<Employee> ListEmpls { get; }

    static ManagerEmployee()
    {
        ListEmpls = new List<Employee>();
    }

    private static int FindEmployee(string login)
    {
        int index = ListEmpls.FindIndex(empl => empl.Data.ContainsKey(login));

        if (index == -1)
            throw new Exception("Сотрудник не найден");

        return index;
    }

    public static void AddEmployee(Employee empl)
    {
        ListEmpls.Add(empl);
    }

    public static void RemoveEmployee(string login)
    {
        ListEmpls.RemoveAll(empl => empl.Data.ContainsKey(login));
    }

    public static void ChangeData(string oldLogin, string newLogin, string newPassword)
    {
        int index = FindEmployee(oldLogin);
        
        ListEmpls[index].Data.Remove(oldLogin);
        ListEmpls[index].Data[newLogin] = newPassword;
    }

    public static string GetPassword(string login)
    {
        int index = FindEmployee(login);
        return ListEmpls[index].Data[login];
    }

}