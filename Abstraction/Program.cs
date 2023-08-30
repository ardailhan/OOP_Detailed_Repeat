using System;

UserService userService = new();
IUserValidateService userValidateService = userService;

interface IUserValidateService
{
    bool ValidateUser(UserInfo userInfo);
}

class UserService : IUserValidateService
{
    public void CreateUser(UserInfo userInfo)
    {
        //..
    }
    public void RemoveUser(int userId)
    {
        //..
    }
    public List<User> Users { get; set; }
    public bool ValidateUser(UserInfo userInfo)
    {
        return true;
    }
}
class UserInfo
{

}
class User
{

}