using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Pam" }, { "age", "66" } });
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Wendell Sr." }, { "age", "70" } });
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Wendy" }, { "age", "44" } });
            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Carla" }, { "age", "40" } });
            myFamily.Add("oldest daughter", new Dictionary<string, string>() { { "name", "Mariah" }, { "age", "4" } });
            myFamily.Add("youngest daughter", new Dictionary<string, string>() { { "name", "Lillian" }, { "age", "3" } });

            foreach (var (familyMember, data) in myFamily)
            {
                var dataList = new List<string>();
                foreach (var dataPoint in data)
                {
                    dataList.Add(dataPoint.Value);
                }
                Console.WriteLine($"{dataList[0]} is my {familyMember} and is {dataList[1]} years old.");
            }
        }
    }
}
   
