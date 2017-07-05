namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
