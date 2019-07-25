using System;

public class Class1
{
    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string str)
        {
            if (isFull())
            {
                WriteLine("The Stack Is Full");
            }
            else
            {
                top++;
                stackArray[top] = str;
            }
        }

        public string pop()
        {
            if (isEmpty())
            {
                WriteLine("The Stack Is Empty.");
                return "--";
            }
            else
            {
                int oldTop = top;
                top--;
                return stackArray[oldTop];
            }
        }
        public string peek()
        {
            return stackArray[top];
        }
        public bool isEmpty() => top == -1;
        public bool isFull() => maxSize - 1 == top;
    }
}
}
