using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._4_MyString
{
    public class MyString
    {
        private char[] myStr;

        public MyString()
        {
            this.MyStr = new char[] { 'U', 'n', 'k', 'n', 'o', 'w', 'n' };
        }

        public MyString(char[] myStr)
            : this()
        {
            this.Copy(myStr);
        }

        public MyString(string myStr)
            : this()
        {
            this.MyStr = myStr.ToCharArray();
        }

        public char[] MyStr
        {
            get
            {
                return this.myStr;
            }

            set
            {
                this.myStr = value;
            }
        }

        public string this[int i]
        {
            get
            {
                return this.MyStr.ToString();
            }

            set
            {
                this.MyStr = value.ToCharArray();
            }
        }

        public static MyString operator +(MyString ms1, MyString ms2)
        {
            return new MyString(new string(ms1.MyStr) + new string(ms2.MyStr));
        }

        public static bool operator >(MyString ms1, MyString ms2)
        {
            if (ms1.CompareTo(ms2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public static bool operator <(MyString ms1, MyString ms2)
        {
            if (ms1.CompareTo(ms2) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(MyString ms1, MyString ms2)
        {
            if (ms1.CompareTo(ms2) == 1 || ms1.CompareTo(ms2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(MyString ms1, MyString ms2)
        {
            if (ms1.CompareTo(ms2) == -1 || ms1.CompareTo(ms2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(MyString ms1, MyString ms2)
        {
            if (ms1.CompareTo(ms2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(MyString ms1, MyString ms2)
        {
            return !(ms1 == ms2);
        }

        public int CompareTo(MyString ms)
        {
            return this.MyStr.ToString().CompareTo(ms.ToString());
        }

        public int FindByChar(char ch)
        {
            string s = new string(this.MyStr);
            return s.IndexOf(ch);
        }

        public char FindByInt(int i)
        {
            return this.MyStr[i];
        }

        public char[] ToCharArray()
        {
            return this.MyStr;
        }

        public override string ToString()
        {
            return new string(this.MyStr);
        }

        public StringBuilder ToStringBuilder()
        {
            return new StringBuilder(new string(this.MyStr));
        }

        private void Copy(char[] str)
        {
            this.MyStr = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                this.MyStr[i] = str[i];
            }
        }
    }
}
