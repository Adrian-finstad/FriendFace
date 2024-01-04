using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FriendFace
{
    public class View
    {
        public Profile UserProfile { get; set; }

        public View(Profile profile)
        {
            UserProfile = profile;
        }
        public void MainView()
        {
            Console.WriteLine("FACEFRIEND");
            Console.WriteLine("1. Profile");
            Console.WriteLine("2. Show Friends");
            Console.WriteLine("3. Show possible friends to add");
            var userInput = Console.ReadLine();
            switch (userInput)
            {    
                case "1":
                    Console.Clear();
                    ShowProfile();
                    break;

                case "2":
                    Console.Clear();
                UserProfile.ShowFriends();
                    MainView();
                    break;

                case "3":
                    Console.Clear();
                    ShowPossibleFriends();
                    break;
                default:
                    Console.Clear();
                    MainView();
                    break;      
            }
        }

        
        public List<Profile> possibleFriends = new List<Profile>()
        {
            new Profile("Kjell-Stian Haraldsen", "Womanizurr69", 25, "Bygg & Anlegg", "Snekker","Grorud" ),
            new Profile("Frank-Remi Guldbrandsen", "Raanern", 34, "Elektro", "Elektriker", "Skjetten"),
            new Profile("Kai-Arne Holth", "Gladtjukken", 22, "Mekanikerlinja", "Lastebiltekniker", "Jessheim"),
            new Profile("Anders-Thorbjørn Simonsen", "Tannlaus", 24, "Idrettsfag", "Fighter", "Holmlia"),

        };


        public void ShowPossibleFriends()
        {
            for (int i = 0; i < possibleFriends.Count; i++)
            {
                
                Console.WriteLine($"{i}{possibleFriends[i].GetName()}, {possibleFriends[i].GetNickname()}");
            }
            Console.WriteLine("Type in the number of the person you wish to add as friend");
            var isNumber = int.TryParse(Console.ReadLine(), out int userInputAsNumber);

            while(!isNumber)
            {
                Console.WriteLine("You're dumber than I thought, please try again.");
                Console.WriteLine("Type in the number of the person you wish to add as friend");
                isNumber = int.TryParse(Console.ReadLine(), out userInputAsNumber);
            }
            if (isNumber && userInputAsNumber >= 0 && userInputAsNumber <= possibleFriends.Count -1)
            {
                ChooseFriendToAdd(userInputAsNumber);
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                Console.Clear();
            }

        }

        public void ChooseFriendToAdd(int friendId)
        {
            UserProfile.Userfriends.Add(possibleFriends[friendId]);
            possibleFriends.Remove(possibleFriends[friendId]);
            
        }


        public void ShowProfile()
        {
            Console.WriteLine($"Name: {UserProfile.GetName()}");
            Console.WriteLine($"Nickname: {UserProfile.GetNickname()}");
            Console.WriteLine($"Age: {UserProfile.GetAge()}");
            Console.WriteLine($"Education: {UserProfile.GetEducation()}");
            Console.WriteLine($"Work: {UserProfile.GetWork()}");
            Console.WriteLine($"Place of living: {UserProfile.GetPlace()}");
            Console.WriteLine("Do you wish to see the main menu? (Y/N)");
            var userInput = Console.ReadLine();
            if (userInput == "Y")
            {
                Console.Clear();
                MainView();
            }
            else
            {
                Console.Clear();
                ShowProfile();
            }
        }






    }
}
