namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events
{
    public sealed class SealedClassWithNestedStaticPartialClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
