namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events
{
    public sealed class SealedClassWithNestedStaticClassWithEventWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
