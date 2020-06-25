using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRecommender
{
    public static class TfidfVectorizer
    {
        public static Dictionary<string, int> Vectorize(List<string> words)
        {
            // Calc TF
            Dictionary<string, int> vectorizer = new Dictionary<string, int>();

            foreach (var word in words)
            {
                // Check if word is already added to vectorizer
                if (!vectorizer.ContainsKey(word))
                {
                    vectorizer.Add(word, 1);
                }
                else
                {
                    // += 1
                    vectorizer[word] = vectorizer[word] += 1;
                }
            }

            // Calc IDF


            return vectorizer;
        }

        public static List<string> SplitWords(string words)
        {
            var newWords = words.Split().ToList();

            return newWords;
        }
    }
}
