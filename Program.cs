using System;

namespace Dog
{
    enum Gender {Male, Female}

    class Program
    {
        static void Main(string[] args)
        {
            Dog Carla = new Dog("Carla","Montgomery",4,Gender.Female);
            Carla.Bark(2);
            Console.WriteLine(Carla.GetTag());

        }
    }

    class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public Dog(string nam, string own, int ag, Gender gend)
        {
            name = nam;
            owner = own;
            age = ag;
            gender = gend;
        }

        public void Bark(int barkNumber)
        {
            for(int i = 1; i<= barkNumber; i++)
            {
                Console.WriteLine("Woof!");
            }
        }

        public string GetTag()
        {
            string possesive;
            string subject;
            if(gender == Gender.Female)
            {
                possesive = "Her";
                subject = "she"; 
            }
            else
            {
                possesive = "His";
                subject = "he";
            }
           
            string plural = "";
            if(age != 1)
            {
                plural = "s";
            }
            string message = $"If lost, call {owner}. {possesive} name is {name} and {subject} is {age} year{plural} old.";
            return message;
        }
    }
}
