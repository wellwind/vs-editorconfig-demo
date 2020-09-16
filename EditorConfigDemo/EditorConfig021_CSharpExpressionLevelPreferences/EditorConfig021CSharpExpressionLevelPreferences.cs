using System;
using System.Collections.Generic;
using System.Threading;

namespace EditorConfigDemo.EditorConfig021_CSharpExpressionLevelPreferences
{
    class EditorConfig021CSharpExpressionLevelPreferences
    {
        // csharp_prefer_simple_default_expression = true
        // 建議改成 void DoWork(CancellationToken cancellationToken = default) { }
        void DoWork(CancellationToken cancellationToken = default(CancellationToken)) { }

        public string Name { get; set; }

        public void Test()
        {
            // csharp_style_deconstructed_variable_declaration = true
            // 建議改成
            // var (name, age) = GetPersonTuple();
            // Console.WriteLine($"{name} {age}");
            var person = GetPersonTuple();
            Console.WriteLine($"{person.name} {person.age}");

            var value = "test";
            // csharp_style_inlined_variable_declaration = true
            // 建議改成 if (int.TryParse(value, out int i) { ...}
            int i;
            if (int.TryParse(value, out i)) { }

            // csharp_style_pattern_local_over_anonymous_function = true
            // 建議改成
            // int fibonacci(int n)
            // {
            //     return n <= 1 ? 1 : fibonacci(n - 1) + fibonacci(n - 2);
            // }
            Func<int, int> fibonacci = null;
            fibonacci = (int n) =>
            {
                return n <= 1 ? 1 : fibonacci(n - 1) + fibonacci(n - 2);
            };

            string[] names = { "Archimedes", "Pythagoras", "Euclid" };
            // csharp_style_prefer_index_operator = true
            // 建議改成 var index = names[^1];
            var index = names[names.Length - 1];

            string sentence = "the quick brown fox";
            // csharp_style_prefer_range_operator = true
            // 建議改成 var sub = sentence[0..^4];
            var sub = sentence.Substring(0, sentence.Length - 4);

            var name = "Mike";
            // csharp_style_throw_expression = true
            // 這條規則設 error 也不會報錯
            // 建議改成 Name = name ?? throw new ArgumentNullException(nameof(Name));
            if (Name == null) { throw new ArgumentNullException(nameof(Name)); }
            Name = name;

            // Original code:
            System.Convert.ToInt32("35");

            // After code fix for IDE0058:

            // csharp_style_unused_value_expression_statement_preference = discard_variable
            // 沒有這條修正選項
            _ = System.Convert.ToInt32("35");

            // csharp_style_unused_value_expression_statement_preference = unused_local_variable
            var unused = Convert.ToInt32("35");
        }

        private (string name, int age) GetPersonTuple()
        {
            return ("Mike", 18);
        }

        int GetCount(Dictionary<string, int> wordCount, string searchWord)
        {
            // csharp_style_unused_value_assignment_preference = discard_variable
            // 這條規則不會報錯，也沒有修正選項
            // 建議改成 _ = wordCount.TryGetValue(searchWord, out var count);
            var unused = wordCount.TryGetValue(searchWord, out var count);
            return count;
        }
    }
}
