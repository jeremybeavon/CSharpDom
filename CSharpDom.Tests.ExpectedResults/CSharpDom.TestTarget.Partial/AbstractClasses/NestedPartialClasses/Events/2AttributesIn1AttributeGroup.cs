namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedPartialClassWithEventWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
