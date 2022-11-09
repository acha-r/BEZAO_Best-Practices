using System;

namespace Best_Practices
{
    /// <summary>
    /// C# Best Coding Practices
    /// </summary>
    
    internal class Program
    {
        static void Main(string[] args)
        {



        }

        ///<summary> Use camelCase when naming variables. The first word should start with lowercase letter </summary>
        public void NamingVariables()
        {
            string one = "One word variable";
            string notOneWord = "More than one word name";
        }




        /// <summary>Use PaschalCase when naming properties. The first word should start with uppercase letter
        /// A property representing a variable should have the same name as the backing variable
        /// Always use properties instead of public variables</summary>
        
        string notOneWord = "More than one word name";
        public string NotOneWord
        {
            get => notOneWord;
            set => notOneWord = value;
        }

        ///<summary>Use all uppercase when declaring const variables.</summary>
        const string PLANET = "earth";

        ///<summary>Never use a name that begins with a numeric character.</summary>
        //string 1stStudent = "Lisa";

        ///<summary>Use nullable data types when you need to</summary>
        int? numberOfPeople = null;

        ///<summary>
        ///Use structs (value type) to store immutable values</summary>
        public struct A
        {
            public int X;
        }


        ///<summary>Use class(reference type) where you need to create an instance</summary>
        public class Person
        {
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        ///<summary>Use ‘0’ (zero) as Default Value Enum Value Types</summary>
        public enum PersonType
        {
            None = 0, 
            Customer = 1
        }

        ///<summary>Always Prefer the foreach(…) Loop</summary>
        public static void CarArr()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        ///<summary>Prefer Runtime Constants over Compile time Constants</summary>
        public readonly string runTime = "runtime constant";
        public const string CompileTime = "compile time constant";

        ///<summary>Method name should clarify the meaning
        ///A method should do only one job at a time. Do not use it for more than one job.</summary>
        void SaveStudentDetails(string studentDetails)
        {
            // SendEmail();
        }

        


    }
}
