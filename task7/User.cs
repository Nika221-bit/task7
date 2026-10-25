namespace task7;

public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }

    public override string ToString()
    {
        return $"Username : {UserName},Password : {Password}";
    }
}