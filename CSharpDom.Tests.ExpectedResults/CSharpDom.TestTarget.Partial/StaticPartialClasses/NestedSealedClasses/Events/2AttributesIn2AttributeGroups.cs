namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events
{
    public static partial class StaticPartialClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
