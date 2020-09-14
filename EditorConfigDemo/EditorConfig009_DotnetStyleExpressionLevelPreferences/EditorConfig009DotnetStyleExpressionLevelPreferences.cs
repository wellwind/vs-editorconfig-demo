using System.Collections.Generic;

namespace EditorConfigDemo.EditorConfig009_DotnetStyleExpressionLevelPreferences
{
    // 以下錯誤都可用 Quick Actions 來修正
    class EditorConfig009DotnetStyleExpressionLevelPreferences
    {
        public void Test01()
        {
            string x = null;
            var y = "World";

            // dotnet_style_coalesce_expression = true
            // 是否使用 null coalescing expressions
            // 正確寫法為 var _ = x ?? y;
            // 不知道為何不會顯示錯誤 Quick Actions 也沒有對應修正方法
            var _ = x == null ? x : y;
        }

        public void Test02()
        {
            // dotnet_style_collection_initializer = true
            // 使用集合初始化的寫法
            // 正確寫法為 var list = new List<int> { 1, 2, 3 };
            var list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
        }

        public void Test03()
        {
            // dotnet_style_explicit_tuple_names = true
            (string name, int age) customer = GetCustomer();
            // 正確寫法為 customer.name
            var name = customer.Item1;
        }

        private (string name, int age) GetCustomer()
        {
            return ("Mike", 18);
        }

        public void Test04()
        {
            var name = "Mike";
            // dotnet_style_null_propagation = true
            // 正確寫法為 name?.ToString()
            var _ = name == null ? null : name.ToString();
        }

        public void Test05()
        {
            // dotnet_style_object_initializer = true:error
            // 正確寫法為 var _ = new User() { Age = 18 }; 
            var _ = new User();
            _.Age = 18;
        }

        public void Test06()
        {
            var x = 1;

            // dotnet_style_prefer_compound_assignment = true
            // 正確寫法為 x += 1;
            x = x + 1;
        }

        public void Test07()
        {
            // dotnet_style_prefer_conditional_expression_over_assignment = true
            // 正確寫法為 string s = expr ? "hello" : "world";

            string s;
            var expr = 1 == 1;
            // Quick Actions -> Convert to conditional expression
            if (expr)
            {
                s = "hello";
            }
            else
            {
                s = "world";
            }
        }

        public string Test08()
        {
            var expr = 1 == 1;

            // dotnet_style_prefer_conditional_expression_over_return = true
            // 正確寫法為 return expr ? "hello" : "world";

            // Quick Actions -> Convert to conditional expression
            if (expr)
            {
                return "hello";
            }
            else
            {
                return "world";
            }
        }

        public void Test09()
        {
            var name = "Mike";
            var age = 18;

            // dotnet_style_prefer_inferred_anonymous_type_member_names = true
            // 正確寫法應簡化成 var person = new { age, name };
            var person = new { age = age, name = name };
        }

        public void Test10()
        {
            var name = "Mike";
            var age = 18;

            // dotnet_style_prefer_inferred_tuple_names = true
            // 正確寫法應簡化成 var tuple = (age, name);
            var tuple = (age: age, name: name);
        }

        public void Test11()
        {
            var value = "Mike";

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = true
            // 正確寫法為 
            // if (value is null)
            //     return;
            if (object.ReferenceEquals(value, null))
                return;
        }
    }

    public class User
    {
        public int Age { get; set; }
    }

    public class Demo
    {
        // dotnet_style_prefer_auto_properties = true
        // 以下程式可以直接簡寫成 public int Age { get }
        // Quick Actions -> Use auto property

        private int age;

        public int Age
        {
            get
            {
                return age;
            }
        }
    }
}
