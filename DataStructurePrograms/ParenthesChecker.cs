using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class ParenthesChecker
    {
        char[] list;
        int top = 0;
        //Reading User Input
        public static void ReadInput()
        {
            Console.Write("Enter the Arithmetic Expression you want to valid : ");
            string input = Console.ReadLine();
            char[] expression = input.ToCharArray();
            ParenthesChecker parenthes = new ParenthesChecker();
            bool result = parenthes.Isbalanced(expression);
            if (result)
            {
                Console.WriteLine("Arithmetic Expression has Balanced Parentheses");
            }
            else
            {
                Console.WriteLine("Arithmetic Expression is  NOT Balanced Parentheses");
            }
        }
        //Push method 
        public bool Push(char x)
        {
            if (top == list.Length)
            {
                return false;
            }
            else
            {
                list[++top] = x;
                return true;
            }
        }
        //Pop method
        public char Pop()
        {
            if (top == 0)
            {
                Console.WriteLine("Underflow error");
                return '\0';
            }
            else
            {
                char element = list[top];
                top--;
                return element;
            }
        }
        //To check the matching characters to pop from stack
        public bool MatchingForParentheses(char char1, char char2)
        {
            if (char1 == '[' && char2 == ']')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '(' && char2 == ')')
                return true;
            else
                return false;
        }
        //Balance method to perform push and pop operation for opening and closing parantheses
        public bool Isbalanced(char[] exp)
        {
            list = new char[exp.Length];
            bool flag = true;
            if (exp.Length == 0)
                return true;

            for (int i = 0; i < exp.Length; i++)
            {

                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                {
                    Push(exp[i]);
                    flag = false;
                }
                if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (MatchingForParentheses(Pop(), exp[i]))
                        flag = true;
                    else
                        return false;
                }
            }
            return flag;
        }
    }
}
