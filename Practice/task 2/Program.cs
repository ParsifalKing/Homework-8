User user = new User("Abdullo", "Abdulloev" ); 
user.UserName =  "Abdu";
user.Password = "12345";
User user2 = new User("Davron", "Ziyoev");
user2.UserName =  "ziyo";
user2.Password = "1234";


string userName  = System.Console.ReadLine();
string passWord = System.Console.ReadLine();

List<User> users = new List<User>();
users.Add(user);
users.Add(user2);

bool found = false;

foreach (var us in users)
{
  found = us.Login(userName, passWord);
}

if (found)
  {
    System.Console.WriteLine("Вход выполнен успешно! Добро пожаловать, г-н/г-жа");
  }
  else 
  {
    System.Console.WriteLine("Ошибка входа");
  }


