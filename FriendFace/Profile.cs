using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    public class Profile
    {
        public List<Profile> Userfriends = new List<Profile>();
        public View MainMenu;

        private string Name { get; set; }
        private int Age { get; set; }
        private string Education { get; set; }
        private string Work {  get; set; }
        private string PlaceOfLiving { get; set; }
        private string Nickname {  get; set; }


        public Profile(string name,string nickname, int age, string education, string work, string place)
        {
            Name = name;
            Age = age;
            Education = education;
            Work = work;
            PlaceOfLiving = place;
            Nickname = nickname;
        }

        public Profile() { }

        public void GenerateProfile()
        {
            Console.WriteLine("Welcome to FriendFace! You will now create your profile.");
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("What would you like your nickname to be?");
            Nickname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Where did you go to school?");
            Education = Console.ReadLine();
            Console.WriteLine("What do you do for work?");
            Work = Console.ReadLine();
            Console.WriteLine("And where do you currently live?");
            PlaceOfLiving = Console.ReadLine();
            Console.WriteLine("Your profile is now complete! Press any button to continue to the main site menu.");
            Console.ReadLine();
            Console.Clear();

        }
        
        public void ShowFriends()
        {
            foreach (Profile friend in Userfriends)
            {
                Console.WriteLine($"Name: {friend.GetName()}");
                Console.WriteLine($"Nickname: {friend.GetNickname()}");
                Console.WriteLine($"Age: {friend.GetAge()}");
                Console.WriteLine($"Education: {friend.GetEducation()}");
                Console.WriteLine($"Work: {friend.GetWork()}");
                Console.WriteLine($"Place of living: {friend.GetPlace()}\n");
                
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            
        }

        public string GetName()
        {
            return Name;
        }

        public string GetNickname()
        {
            return Nickname;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetEducation()
        {
            return Education;
        }

        public string GetWork()
        {
            return Work;
        }

        public string GetPlace()
        {
            return PlaceOfLiving;
        }




       



    }
}
