namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events
{
    public partial class PartialClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
