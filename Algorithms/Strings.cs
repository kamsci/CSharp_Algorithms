using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Strings
    {
        public static bool HasAllUniqueChar(string source)
        {
            Dictionary<char, int> uniqueChar = new Dictionary<char, int>(); 

            for(int i = 0; i < source.Length; i++)
            {
                if (uniqueChar.ContainsKey(source[i]))
                {
                    return false;
                }
                else
                {
                    uniqueChar.Add(source[i], i);
                }
            }
            return true;
        }
        public static string ReverseString(string source)
        {
            char[] sourceArray = source.ToArray();
            char[] resultArray = ReverseArray(sourceArray);

            string result = string.Join("", resultArray);

            return result;
        }
        public static string ReverseWords(string source)
        {
            string result = "";
            string reverseAll = ReverseString(source);
            int start = 0;
            int end;

            for(int i = 0; i < reverseAll.Length; i++)
            {
                if (Char.IsWhiteSpace(reverseAll[i]) || i == reverseAll.Length -1)
                {
                    if(i == reverseAll.Length - 1)
                    {
                        end = reverseAll.Length - start;
                    }
                    else
                    {
                        end = i - start;
                    }

                    string temp = reverseAll.Substring(start, end);
                    temp = ReverseString(temp);
                    result += temp;
                    start = i + 1;

                    if(i != reverseAll.Length - 1)
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }
        public static bool IsPermutation(string sourceFirst, string sourceSecond)
        {
            if(sourceFirst.Length != sourceSecond.Length)
            {
                return false;
            }
            char[] firstArr = sourceFirst.ToArray();
            char[] secondArr = sourceSecond.ToArray();
            Array.Sort(firstArr);
            Array.Sort(secondArr);

            if(firstArr.ToString() == secondArr.ToString())
            {
                return true;
            }
            return false;
        }

        public static string Remove(string s)
        {
            if (s == null) { return "no string"; }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().Equals("b", StringComparison.InvariantCultureIgnoreCase))
                {
                    string temp = s.Remove(i, 1);
                    s = temp;
                    if (s.Length != 0) { i--; }
                }
                if (s.Length > 1
                    && i != s.Length - 1
                    && s[i + 1].ToString().Equals("c", StringComparison.InvariantCultureIgnoreCase)
                    && s[i].ToString().Equals("a", StringComparison.InvariantCultureIgnoreCase))
                {
                    string temp = s.Remove(i, 2);
                    s = temp;
                    if (i != 0 && s.Length > 2)
                    {
                        i = i - 2;
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            return s;
        }
        public static string RemoveInput(string[] remove, string original)
        {
            string finalStringResult = String.Empty;
            string stringToRemoveFrom = original;

            foreach (string part in remove)
            {
                if(stringToRemoveFrom.Length == 0)
                {
                    break;
                }
                if(part.Length > stringToRemoveFrom.Length)
                {
                    break;
                }

                stringToRemoveFrom = flexibleRemove(part, stringToRemoveFrom);
                finalStringResult += stringToRemoveFrom;
            }

            return finalStringResult;
        }

       public static string RemoveInput(string remove, string source)
        {
            if (source.Length == 0 || remove.Length == 0 || remove.Length > source.Length)
            {
                return source;
            }

            string lastLetter = remove[remove.Length - 1].ToString();

            for (int i = remove.Length - 1; i < source.Length; i++)
            {
                if (remove.Length > source.Length)
                {
                    break;
                }

                if (source[i].ToString().Equals(lastLetter, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (remove.Length == 1)
                    {
                        string temp = source.Remove(i, 1);
                        source = temp;
                        if (source.Length != 0)
                        {
                            i--;
                        }
                    }
                    else if(Strings.isRemoveInSource(remove, source, i))
                    {
                        string temp = source.Remove(i - (remove.Length - 1), remove.Length);
                        source = temp;
                        if (source.Length != 0)
                        {
                            i--;
                        }
                    }
                }
            }

            return source;
        }

        #region
        private static char[] ReverseArray(char[] sourceArray)
        {
            int backCount = sourceArray.Length - 1;
            float half = sourceArray.Length / 2;

            for (int i = 0; i < Math.Round(half); i++)
            {
                char temp = sourceArray[i];
                sourceArray[i] = sourceArray[backCount];
                sourceArray[backCount] = temp;
                backCount--;
            }
            return sourceArray;
        }
        private static bool isRemoveInSource(string remove, string source, int idx)
        {
            if (idx < remove.Length - 1)
            {
                return false;
            }
            for (int j = remove.Length - 2; j >= 0; j--)
            {
                idx--;
                if (!source[idx].Equals(remove[j]))
                {
                    return false;
                }
            }
            return true;
        }

        private static string flexibleRemove(string part, string stringToRemoveFrom)
        {
            return "";
        }
        #endregion
    }
}
