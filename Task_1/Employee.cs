namespace Task_1;

public class Employee
{
    public Dictionary<string, string> Data { get; }
    
    public Employee(string login, string password)
    {
        Data = new Dictionary<string, string>();
        Data.Add(login, password);
    }
    

    public override string ToString()
    {
        foreach (KeyValuePair<string, string> keyValue in Data)
        {
            return $"Login: {keyValue.Key}, Password: {keyValue.Value}";
        }

        return "";
    }
}
