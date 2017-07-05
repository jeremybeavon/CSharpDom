namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
