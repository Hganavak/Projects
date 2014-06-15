using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin {
    public class PigLatinizer {
        public static List<string> vowels = new List<string>{"a","e","i","o","u"}; 
        
        public static string PigLatinify(string word){
            word = word.ToLower();
            return vowels.Contains(word.Substring(0, 1)) 
                ? word + "way"
                : word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay";
        }
    }
}
