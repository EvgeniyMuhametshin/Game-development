using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
    public delegate void reverseFunc();

    class Doubler
    {
        int value;
        int steps;
        int goal;

        Stack<reverseFunc> operations = new Stack<reverseFunc>();

        new Random rand = new Random();

        public int Value { get { return this.value; } }
        public int Steps { get { return this.steps; } }
        public int Goal { get { return this.goal; } }

        public Doubler()
        {
            this.value = 0;
            this.steps = 0;
            this.goal = 0;
        }

        public void Increment()
        {
            this.value++;
            this.steps++;
            operations.Push(new reverseFunc(Decrement));
        }

        public void Double()
        {
            this.value *= 2;
            this.steps++;
            operations.Push(new reverseFunc(DivideByTwo));
        }

        public void Decrement()
        {
            this.value--;
            this.steps--;
        }

        public void DivideByTwo()
        {
            this.value /= 2;
            this.steps--;
        }

        public void CheckStack()
        {
            reverseFunc reverseFunc;
            if (operations.Count != 0)
            {
                reverseFunc = operations.Pop();
                reverseFunc();
            }
            return;
        }

        public void Reset()
        {
            this.value = 1;
            this.steps = 0;
            operations.Clear();
        }

        public void GetGoal()
        {
            this.goal = rand.Next(2, 2049);
        }

        public bool CheckGoal()
        {
            return this.value == this.goal ? true : false;
        }
    }
}