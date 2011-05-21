//Copyright (c) 2011 E.Laverick

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in
//all copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//THE SOFTWARE.

namespace L_System_OpenTK
{
    class l_system
    {
        private string[,] rules = new string[30, 2];
        private int ruleCount;

        public string iterateString(string input)
        {
            string temp = "";
            foreach (char c in input)
            {
                bool found = false;
                for (int i = 0; i < ruleCount; i++)
                {
                    if (c == rules[i, 0].ToCharArray()[0])
                    {
                        temp += rules[i, 1];
                        found = true;
                        break;
                    }
                }
                if (!found)
                    temp += c;
            }
            return temp;
        }

        public void calcRules(string ruleString)
        {
            ruleCount = 0;

            foreach (string s in ruleString.Split('\n'))
            {
                string[] temp = s.Split('=');
                rules[ruleCount, 0] = temp[0].Trim();
                rules[ruleCount, 1] = temp[1].Trim();
                ruleCount++;
            }
        }
    }
}
