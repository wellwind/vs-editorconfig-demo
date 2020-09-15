using System;
using System.Collections.Generic;

namespace EditorConfigDemo.EditorConfig013_CSharpExpressionBodiedMembers
{
    class EditorConfig013CSharpExpressionBodiedMembers<T>
    {
        public int Age = 18;

        // csharp_style_expression_bodied_methods = false
        // 建議改為 public int GetAge() { return this.Age }
        public int GetAge() => Age;

        private string _name = "Mike";
        // csharp_style_expression_bodied_properties = true
        // 建議改為 public string Name => _name;
        public string Name { get { return _name; } }

        private List<T> _values = new List<T>();
        // csharp_style_expression_bodied_indexers = true
        // 建議改為 public T this[int i] => _values[i];
        public T this[int i] { get { return _values[i]; } }

        private string _sex = "F";
        // csharp_style_expression_bodied_accessors = true
        // 建議改為 public string Sex { get => _sex; set => _sex = value; }
        public string Sex { get { return _sex; } set { _sex = value; } }

        // csharp_style_expression_bodied_lambdas = true
        // 建議改為 Func<int, int> square = x => x * x;
        Func<int, int> square = x => { return x * x; };

        // csharp_style_expression_bodied_constructors = false:error
        // 建議改為 public int EditorConfig013CSharpExpressionBodiedMembers(int age) { Age = age; }
        public EditorConfig013CSharpExpressionBodiedMembers(int age) => Age = age;

        // csharp_style_expression_bodied_local_functions = false
        // 建議改為
        // void Hello()
        // {
        //    Console.WriteLine("Hello");
        // }
        void Hello() => Console.WriteLine("Hello");
    }

    public class ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public ComplexNumber(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // csharp_style_expression_bodied_operators = false
        // 建議改為
        // public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2)
        // { return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary); }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            => new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }
}
