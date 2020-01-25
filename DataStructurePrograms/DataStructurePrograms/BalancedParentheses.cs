using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms{
    class BalancedParentheses{
        public class Stack1
        {
            public int top = -1;
            public char[] items = new char[100];

            public void Push1(char x)
            {
                if (top == 99)
                {
                    Console.WriteLine("Stack full");
                }
                else
                {
                    items[++top] = x;
                }
            }

           public char Pop1()
            {
                if (top == -1)
                {
                    Console.WriteLine("Underflow error");
                    return '\0';
                }
                else
                {
                    char element = items[top];
                    top--;
                    return element;
                }
            }

            Boolean IsEmpty()
            {
                return (top == -1) ? true : false;
            }
        }

        public bool Parentheses(char[] exp) 
        {
            Stack1 st1 = new Stack1();
            Stack st = new Stack();

            for(int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                    st1.Push1(exp[i]);
                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    if (!IsMatchingPair(st1.Pop1(), exp[i]))
                        return false;
                    else if (st.IsEmpty())
                    {
                        return false;
                    }
                }
                    
            }
            if (st.IsEmpty())
                return true; 
            else
            {
                return false;
            }

        }
       private static Boolean IsMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }

    }
}
