namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events
{
    public static class StaticClassWithNestedAbstractPartialClassWithEventWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
