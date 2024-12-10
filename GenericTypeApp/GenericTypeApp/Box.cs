using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeApp
{
    internal class Box<T> //Not related to ant type
    {
        private T content { get; set; }

        public Box(T initialValue) 
        {
            content = initialValue;
        }

        public void UpdateContext(T newContent) 
        {
            content = newContent;
            Console.WriteLine($"Updated content to {content}");
        }

        public T GetContent()
        {
            return content;
        }
    }
}
