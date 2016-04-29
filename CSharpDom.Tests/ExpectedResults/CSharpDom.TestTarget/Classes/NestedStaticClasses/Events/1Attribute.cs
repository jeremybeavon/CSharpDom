namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Events
{
    public class ClassWithNestedStaticClassWithEventWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
