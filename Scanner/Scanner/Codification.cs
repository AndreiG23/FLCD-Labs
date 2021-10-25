using System;
using System.Collections.Generic;
using System.Text;

namespace Scanner
{
    public class Codification
    {
        private List<string> separators = new List<string>{ "[", "]", "(", ")", "{", "}", ":", ";", " ", "\n" };
        private List<string> operators = new List<string> { "+", "-", "/", "*", "%", "=", "<", "<=", "==", ">=", ">", "!=", "!", "&&", "||" };
        private List<string> reservedWords = new List<string> { "int", "string", "bool", "return", "if", "else", "while", "ReadLine", "WriteLine","Main" };

        private Dictionary<string, int> codes;

        public Codification()
        {
            initCodes();
        }

        private void initCodes()
        {
            this.codes = new Dictionary<string, int>();
            codes.Add("identifier", 0);
            codes.Add("constant", 1);

            int i = 2;
            foreach(var s in separators)
            {
                codes.Add(s, i);
                i++;
            }
            foreach (var o in operators)
            {
                codes.Add(o, i);
                i++;
            }
            foreach (var r in reservedWords)
            {
                codes.Add(r, i);
                i++;
            }
        }

        public List<string> getSeparators()
        {
            return separators;
        }

        public List<string> getOperators()
        {
            return operators;
        }

        public List<string> getReservedWords()
        {
            return reservedWords;
        }

        public Dictionary<string,int> getCodes()
        {
            return codes;
        }
    }
}
