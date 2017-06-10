using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication19
{ 
    class Expression
    {
        private char sign;
        private float value;
        private Expression left;
        private Expression right;

        public Expression()
        {
            sign = ' ';
            value = 0;
            left = null;
            right = null;
        }
        public Expression(char s, float v)
        {
            sign = s;
            value = v;
            left = null;
            right = null;
        }
        public Expression(char s, float v, Expression l, Expression r)
        {
            sign = s;
            value = v;
            left = l;
            right = r;
        }
        public void RemoveSpaces(ref string s)
        {
            string aux = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ')
                    aux += s[i];
            s = aux;
        }
        public bool RemoveUselessBrackets(ref string s)
        {
            int brack = 0;
            bool ok = true;
            if ( s[0] != '(' || s[s.Length-1] != ')' )
                return false;
            for ( int i = 0; i < s.Length-1; i++ )
            {
                if (s[i] == '(' )
                    brack++;
                if (s[i] == ')')
                    brack--;
                if (brack == 0)
                    ok = false;
            }
            if ( ok )
            {
                s = s.Remove(0, 1);
                s = s.Remove(s.Length - 1, 1);
            }
            return ok;
        }
        public int FindCharNotInBrackets(char c, string s)
        {
            int brack = 0;
            for ( int i = 0; i < s.Length; i++ )
            {
                if (s[i] == '(')
                    brack++;
                if (s[i] == ')')
                    brack--;
                if (brack == 0 && s[i] == c)
                    return i;
            }
            return -1;

        }
        public void CutString(string s, int p, ref string sleft, ref string sright )
        {
            sleft = s.Remove(p);
            sright = s.Remove(0, p+1);
        }
        public Expression FromString(string s)
        {
            int pos = 0;
            string stanga = "";
            string dreapta = "";
            RemoveSpaces(ref s);
            while (RemoveUselessBrackets(ref s)) ;
            pos = FindCharNotInBrackets('+', s);
            if (pos != -1)
            {
                CutString(s, pos, ref stanga, ref dreapta);
                return new Expression('+', -1, FromString(stanga), FromString(dreapta));
            }
            pos = FindCharNotInBrackets('-', s);
            if (pos != -1)
            {
                CutString(s, pos, ref stanga, ref dreapta);
                return new Expression('-', -1, FromString(stanga), FromString(dreapta));
            }
            pos = FindCharNotInBrackets('*', s);
            if (pos != -1)
            {
                CutString(s, pos, ref stanga, ref dreapta);
                return new Expression('*', -1, FromString(stanga), FromString(dreapta));
            }
            pos = FindCharNotInBrackets('/', s);
            if (pos != -1)
            {
                CutString(s, pos, ref stanga, ref dreapta);
                return new Expression('/', -1, FromString(stanga), FromString(dreapta));
            }
            pos = FindCharNotInBrackets('^', s);
            if (pos != -1)
            {
                CutString(s, pos, ref stanga, ref dreapta);
                return new Expression('^', -1, FromString(stanga), FromString(dreapta));
            }
            pos = FindCharNotInBrackets('x', s);
            if (pos != -1)
                return new Expression('x', 0);
            pos = FindCharNotInBrackets('a', s);
            if (pos != -1)
                return new Expression('a', 0);
            else
            {
                try
                {
                    return new Expression('n', Convert.ToSingle(s));
                }
                catch
                {
                    throw new System.ArithmeticException(s);
                }
            }
        }
        public float Calculate(float x, float a)
        {
            switch(sign)
            {
                case '+': return left.Calculate(x, a) + right.Calculate(x, a);
                case '-': return left.Calculate(x, a) - right.Calculate(x, a);
                case '*': return left.Calculate(x, a) * right.Calculate(x, a);
                case '/': return left.Calculate(x, a) / right.Calculate(x, a);
                case '^': return Convert.ToSingle(Math.Pow(Convert.ToDouble(left.Calculate(x, a)), Convert.ToDouble(right.Calculate(x, a))));
                case 'n': return value;
                case 'x': return x;
                case 'a': return a;
                default: return 0;
            }
        }
    }
}
