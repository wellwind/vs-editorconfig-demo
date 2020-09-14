using System;

namespace EditorConfigDemo.EditorConfig005_DotnetStyleQualification
{
    public class EditorConfig005DotnetStyleQualification
    {
        public string Name { get; set; }

        private int capacity = 0;

        public event EventHandler MyEvent;

        public void Test()
        {
            // dotnet_style_qualification_for_field = false
            this.capacity = 1;

            // dotnet_style_qualification_for_property = false
            this.Name = "Mike";

            // dotnet_style_qualification_for_method = false
            this.Test2();

            // dotnet_style_qualification_for_event = false
            this.MyEvent += EditorConfig004DotnetStyleQualification_MyEvent;
        }

        public void Test2()
        {

        }

        private void EditorConfig004DotnetStyleQualification_MyEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
