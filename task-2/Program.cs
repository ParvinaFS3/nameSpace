using System;

class Program
{
    static void Main()
    {
        
        User[] users = {
            new Student("Aslanova", "Nargiz", "nargiz_lan", "password123", 10),
            
        };

        Console.Write("Enter username: ");
        string enteredUsername = Console.ReadLine();
        Console.Write("Enter password: ");
        string enteredPassword = Console.ReadLine();

        
        User authenticatedUser = null;
        foreach (var user in users)
        {
            if (user.Username == enteredUsername && user.Password == enteredPassword)
            {
                authenticatedUser = user;
                break;
            }
        }
        // Əgər istifadəçi tapılıbsa və istifadəçi bir tələbədirsə Grade-i ekrana çap et
        if (authenticatedUser is Student student)
        {
            Console.WriteLine($"Welcome, {student.Name} {student.Surname}!");
            Console.WriteLine($"Your Grade: {student.Grade}");
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }

}
class User
{
    public string Name { get; }
    public string Surname { get; }
    public string Username { get; }
    public string Password { get; }

    public User(string name, string surname, string username, string password)
    {
        Name = name;
        Surname = surname;
        Username = username;
        Password = password;
    }
}


class Student : User
{
    public int Grade { get; }

    public Student(string name, string surname, string username, string password, int grade)
        : base(name, surname, username, password)
    {
        Grade = grade;
    }
}




/*using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 2, 3, 4, 7 };
        int[] arr2 = { 3, 2, 7 };

        bool result = IsArrayContains(arr1, arr2);
        Console.WriteLine(result); // Output: False

        int[] arr3 = { 2, 3, 4, 7 };
        int[] arr4 = { 3, 4 };

        bool result2 = IsArrayContains(arr3, arr4);
        Console.WriteLine(result2); // Output: True
    }

    static bool IsArrayContains(int[] array1, int[] array2)
    {
        if (array1.Length < array2.Length)
        {
            return false;
        }

        // İkinci arrayin bütün elementləri ilə birinci arrayin elementlərini müqayisə et
        for (int i = 0; i <= array1.Length - array2.Length; i++)
        {
            if (IsSubArray(array1, array2, i))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsSubArray(int[] array1, int[] array2, int startIndex)
    {
        for (int i = 0; i < array2.Length; i++)
        {
            if (array1[startIndex + i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }
}*/






