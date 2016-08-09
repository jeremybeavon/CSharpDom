namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events
{
    public static class StaticClassWithNestedClassWithEventWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
