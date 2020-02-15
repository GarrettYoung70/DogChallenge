using System;

namespace Dog
{
    //Creating the enum for the gender of the dog
    public enum Gender
        {
            Male,
            Female
        }
    
    //This is the dog class
    class Dog
    {
        //These are the public properties 
        public string name;
        public string owner;
        public int age;
        public Gender gender;

        //Constructor that initializes all of the properties
        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        //Method that counts the number of times the dog barks and outputs the corresponding Woof!
        public void Bark(int barks)
        {
            for(int i = 0; i < barks; i++)
            {
                Console.WriteLine("Woof!");
            }
        }
        
        //Method that returns the output string based on the information of the dog
        public string GetTag()
        {
            string tag = "If lost, call "+ owner +". ";
            //Creates the output based on the gender of the dog
            if(gender == 0)
            {
                tag += "His name is "+ name +" and he is "+ age;
            }
            else
            {
                tag += "Her name is " + name +" and she is "+ age;
            }

            //If the dog is 1 year old or younger, the output is singular and vice versa
            if(age <= 1)
            {
                tag += " year old.";
            }
            else
            {
                tag += " years old.";
            }
            return tag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Testing if the program works
            
            Dog puppy = new Dog("Max", "Garrett", 6, Gender.Male);  // create object instance
                        puppy.Bark(5); // output 5 'Woof!'s
                        Console.WriteLine(puppy.GetTag()); // output: If lost, call Garrett. His name is Max and he is 6 years old.

            Dog myDog = new Dog("Hallie", "Claudia", 1, Gender.Female);  // create object instance
                        myDog.Bark(3); // output 3 'Woof!'s
                        Console.WriteLine(myDog.GetTag()); // output: If lost, call Claudia. Her name is Hallie and she is 1 year old.
        }
    }
}
