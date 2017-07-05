namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Events
{
    public static class StaticClassWithNestedStaticPartialClassWithEventWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
