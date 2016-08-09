namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events
{
    public static class StaticClassWithNestedAbstractClassWithEventWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
