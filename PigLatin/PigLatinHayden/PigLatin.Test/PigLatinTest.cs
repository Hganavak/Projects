using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PigLatin.Test {
    [TestClass]
    public class PigLatinTest {
        [TestMethod]
        public void ReturnsCorrectOutputForFirstLetterConsonant(){
            string word = "hayden";
            string result = PigLatinizer.PigLatinify(word);
            string expected = "aydenhay";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsCorrectOutputForFirstLetterVowel(){
            string word = "apple";
            string result = PigLatinizer.PigLatinify(word);
            string expected = "appleway";

            Assert.AreEqual(expected, result);
        }
    }
}
