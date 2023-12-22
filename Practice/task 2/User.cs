public class User
{
   public string FirstName { get; set; }
   public string LastName {get; set;}
   public string UserName {get; set;}
   public string Password {get; set;}
   

    public User()
    {
        
    }
   public User(string firstName, string lastName)
   {
    FirstName = firstName;
    LastName = lastName;
   } 

    //methods
   public string GetInfo()
   {
    return $"{FirstName} {LastName}";
   }
   public bool Login(string username, string pass)
   {
       if (username == UserName && pass == Password)
        return true;
        else return false;
   } 
}