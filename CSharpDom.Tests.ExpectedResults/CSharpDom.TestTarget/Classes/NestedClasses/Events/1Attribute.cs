namespace CSharpDom.TestTarget.Classes.NestedClasses.Events
{
    public class ClassWithNestedClassWithEventWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
