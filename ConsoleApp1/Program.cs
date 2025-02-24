//TASK 1
// using System;
// using System.Collections.Generic;
// class Program
// {
//     static void Main()
//     {
//         List<double> I = new List<double> { 0.15, 0.33, 0.22, 0.49, 0.41 };
//         List<double> U = new List<double> { 1.3, 2.5, 2.0, 4.2, 4.7 };

//         double resistance = calculateResistance(I, U);
//         Console.WriteLine($"Approximate value of R = {resistance:F2}");


//     }
//     static double calculateResistance(List<double> I, List<double> U)
//     {
//         int n = I.Count;
//         double sumI = 0;
//         double sumU = 0;
//         double sumIU = 0;
//         double sumI2 = 0; 

//         for (int i = 0; i < n; i++)
//         {
//             sumI += I[i];
//             sumU += U[i];
//             sumIU += I[i] * U[i];
//             sumI2 += I[i] * I[i];
//         }
        
//         double numerator = n * sumIU - sumI * sumU;
//         double denominator = n * sumI2 - sumI * sumI;
        
//         if (denominator == 0)
//         {
//             throw new InvalidOperationException("ERROr");
//         }

//         double R = numerator/denominator;
//         return R;
//     }
// }
//TASK 2 
// using System;
// using System.Collections.Generic;
// using Newtonsoft.Json;
// using System.IO;
// class Progrsm 
// {
//     static void Main()
//     {
//         List <Dictionary<string, string>> DICTIONARES = new List<Dictionary<string, string>> 
//         {
//             new Dictionary<string, string> {{"Brand", "Apple"}, {"OS", "IOS"} ,{"Color", "Black"}},
//             new Dictionary<string, string> {{"Brand", "Android"}, {"OS", "ANDROID"} ,{"Color", "White"}},
//             new Dictionary<string, string> {{"Brand", "Google"}, {"OS", "ANDROID"} ,{"Color", "Blue"}}
//         };
//         string searchKey = "Color";

//         Dictionary<string, int> results = new Dictionary<string, int>();

//         int count = 0;
//         foreach (var dict in DICTIONARES)
//         {
            
//             if (dict.ContainsKey(searchKey))
//             {
//                 count++;
//             }

//             results[searchKey] = count;
//         }

//         Console.WriteLine($"Number of key '{searchKey}': {results[searchKey]}");
        
//         string jsonResult = JsonConvert.SerializeObject(results, Formatting.Indented);
//         File.WriteAllText("search_results.json", jsonResult);

//         Console.WriteLine("Saved in file: search_results.json");

//     }
// }
//TASK 3
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = { "british", "haribo", "bubble", "hoco", "barbados", "protein" };

        var finalResult = input
            .Select(s => s.Length % 2 == 1 ? s.First() : s.Last()) 
            .OrderByDescending(c => (int)c) 
            .ToList(); 
        Console.WriteLine(string.Join(", ", finalResult));
    }
}
