namespace FinalProject.Classes
{
    public class UserProfile
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public UserProfile(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayProfile()
        {
            Console.WriteLine($"User Profile:\n  Name: {Name}\n  Age: {Age}");
        }
    }
}