using System;

namespace MoshAbstractClass
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();

        public void Select()
        {
            Console.WriteLine("Select a shape.");
        }

        public void Copy()
        {
            Console.WriteLine("Copy a shape.");
        }
    }
}
