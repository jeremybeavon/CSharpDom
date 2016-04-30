namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events
{
    public abstract class AbstractClassWithNestedStaticClassWithEventWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
