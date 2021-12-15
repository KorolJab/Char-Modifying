using System.Text;
namespace SimpleReplacingAlgorythm
{ 
    //Could be your namespace

    /// <summary>
    /// class Replacer 
    /// minor class of the programm
    /// retirning modified string
    /// </summary>

    public class Replacer
    {

        /// <summary>
        /// method ReplaceChar replacing reccuring letters with ")" and not with "(" 
        /// <param name="st"> sended in method ReplaceChar type string </param>
        /// <returns>edited string</returns>
        /// </summary>
        public string ReplaceChar(string st)
        {
            

            string returned = "";
            //dictionary creating to keep used chars
            Dictionary<char, int> charRay = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();
            //main part of the method
            for (int i = 0; i < st.Length; i++)
            {
                if (!charRay.ContainsKey(st[i]))
                {
                    charRay.Add(st[i], i);
                    sb.Append('(');
                }
                else
                {
                    if (charRay[st[i]] == -1)
                    {
                        sb.Append(')');
                    }
                    else
                    {
                        sb.Replace('(', ')', charRay[st[i]], charRay[st[i]] + 1);
                        charRay[st[i]] = -1;
                        sb.Append(')');
                    }
                }
            }
            return returned;
        }
    }
}
