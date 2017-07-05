namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
