namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events
{
    public sealed class SealedClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
