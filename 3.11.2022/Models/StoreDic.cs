namespace Project.Models;

public class StoreDic
{
    public Dictionary<string, User>? Users;

    public void AddUSer()
    {
        Users = new Dictionary<string, User>();
    }
}