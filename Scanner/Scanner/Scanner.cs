using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Scanner
{
    public class Scanner
    {
        private ST symbolTable = new ST(50);
        private ProgramInternalForm pif = new ProgramInternalForm();
        private Codification codification = new Codification();

        public Scanner() { }

        public void scanFile(string fileName)
        {
            using(StreamReader file = new StreamReader(fileName))
            {
                string ln;
                while((ln = file.ReadLine()) != null)
                {

                }
                file.Close();
            }
        }


        public bool scanLine(List<string> tokens, int line)
        {
            bool lexicallyCorrect = true;
            List<string> specialCase = new List<string> { "(", "=", "==", "<", ">", "<=", ">=", "!=" };
            String lastToken = "";
            for (int i = 0; i < tokens.Count; ++i)
            {
                String token = tokens[i];
                if (this.isIdentifier(token))
                {
                    int code = this.codification.getCodes()["identifier"]; // 0
                    this.symbolTable.Add(token);
                    Pair position = this.symbolTable.Search(token);
                    this.pif.add(code, position);
                }
                else if (this.isConstant(token))
                {
                    int code = this.codification.getCodes().["constant"]; // 1
                    this.pif.add(code, new Pair(-1, -1));
                }
                else if ((token.Equals("-") || token.Equals("+")) && (this.isNumber(tokens.[i + 1])) &&
                        specialCase.Contains(lastToken))
                {
                    token += tokens.[i + 1];
                    i++;
                    if (!token.Equals("-0"))
                    {
                        int code = this.codification.getCodes()["constant"]; // 1
                        this.pif.add(code, new Pair(-1, -1));
                    }
                    else
                    {
                        Console.WriteLine("Error at line: " + line + ". Invalid token " + token);
                        lexicallyCorrect = false;
                    }
                }
                else if (this.isOperator(token) || this.isSeparator(token) || this.isReservedWord(token))
                {
                    int code = this.codification.getCodes()[token];
                    this.pif.add(code, new Pair(-1, -1));
                }
                else
                {
                    Console.WriteLine("Error at line: " + line + ". Invalid token " + token);
                    lexicallyCorrect = false;
                }
                lastToken = token;
            }

            return lexicallyCorrect;
        }

        public bool isSeparator(string token)
        {
            return this.codification.getSeparators().Contains(token);
        }

        public bool isOperator(string token)
        {
            return this.codification.getOperators().Contains(token);
        }

        public bool isReservedWord(string token)
        {
            return this.codification.getReservedWords().Contains(token);
        }

        public bool isIdentifier(string token)
        {
            string pattern = "^[a-zA-Z]([a-zA-Z0-9_]*$)";
            return token.Contains(pattern);
        }

        public bool isConstant(String token)
        {
            string number = "^([1-9][0-9]*)|0$";
            string stringVar = "^\"[a-zA-Z0-9_.:;,?!*' ]*\"$";
            string character = "^\'[a-zA-Z0-9_.:;,?!*\" ]\'$";
            return token.Contains(number) || token.Contains(stringVar) || token.Contains(character);
        }

        public bool isNumber(String token)
        {
            string number = "^([1-9][0-9]*)|0$";
            return token.Contains(number);
        }
    }
}
