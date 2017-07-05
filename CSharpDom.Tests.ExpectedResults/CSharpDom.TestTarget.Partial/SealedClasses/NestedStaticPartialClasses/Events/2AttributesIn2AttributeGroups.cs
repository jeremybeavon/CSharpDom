namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events
{
    public sealed class SealedClassWithNestedStaticPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public static partial class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event;
        }
    }
}
