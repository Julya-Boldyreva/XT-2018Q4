using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._4_MyString
{
    class MyString
    {
        private char[] myStr;
        public MyString()
        {
            this.MyStr = new char[] { 'U', 'n', 'k', 'n', 'o', 'w', 'n' };
        }

        public MyString(char[] myStr)
            : this()
        {
            Copy(myStr);
        }

        public MyString(string myStr)
            : this()
        {
            this.MyStr = myStr.ToCharArray();
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

        private void Copy(char[] str)
        {
            MyStr = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                MyStr[i] = str[i];
            }    
        }

        public int CompareTo(MyString ms)
        {
            return this.MyStr.ToString().CompareTo(ms.ToString());
        }

        public static MyString operator +(MyString ms1, MyString ms2)
        {
            return new MyString(new String(ms1.MyStr) + new String(ms2.MyStr));
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

        public int FindByChar(char ch)
        {
            string s = new string(MyStr);
            return s.IndexOf(ch);
        }

        public char FindByInt(int i)
        {
            return MyStr[i];
        }

        public char[] ToCharArray()
        {
            return MyStr;
        }

        public override string ToString()
        {
            return new String(MyStr);
        }

        public StringBuilder ToStringBuilder()
        {
            return new StringBuilder(new String(MyStr));
        }
    }
}
