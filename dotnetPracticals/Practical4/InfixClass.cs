using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class InfixClass
    {
        public void infixToPostfix(String Infix, String Postfix)
        {
            Postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < Infix.Length; i++)
            {
                ch = Infix[i];
                if (isOperator(ch))
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(ch);
                    }
                    else
                    {
                        if (ch == '(')
                        {
                            stack.Push(ch);
                        }
                        else
                        {
                            if (ch == ')')
                            {
                                while (stack.Peek() != ')')
                                {
                                    Postfix += stack.Pop();
                                }
                                stack.Pop();
                            }
                            else
                            {
                                if (Priority(ch) > Priority(stack.Peek()))
                                {
                                    
                                }
                            }

                        }
                    }

                }
                else
                {
                    Postfix += ch;
                }

            }
        }

        public bool isOperator(char ch)
        {
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '(' || ch == ')' || ch == '%')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Priority(char ch)
        {
            switch (ch)
            {
                case '(' : 
                    return 0;
                    break;
                case '+':
                case '-':
                    return 1;
                    break;
                case '%':
                case '/':
                case '*':
                    return 2;
                    break;
            }
            return ch;
        }
    }

}
