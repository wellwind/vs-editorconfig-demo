using System;
using System.Collections.Generic;
using System.Text;

namespace EditorConfigDemo.EditorConfig012_CSharpVarPreferences
{
    class EditorConfig012CSharpVarPreferences
    {
        public void Test()
        {
            // csharp_style_var_for_built_in_types = true
            // 內建型別可以直接用 var
            int x = 5;

            Console.WriteLine(x);
        }

        public void Test2()
        {
            // csharp_style_var_when_type_is_apparent = true
            // 明顯可被推論出型別的可以直接用 var
            Customer obj = new Customer();

            Console.WriteLine(obj);
        }

        public void Test3()
        {
            // csharp_style_var_elsewhere = true
            // 除了上述兩種外，是否建議優先使用 var
            string name = GetName();

            Console.WriteLine(name);
        }

        public string GetName()
        {
            return "Mike";
        }
    }

    public class Customer { }
}
