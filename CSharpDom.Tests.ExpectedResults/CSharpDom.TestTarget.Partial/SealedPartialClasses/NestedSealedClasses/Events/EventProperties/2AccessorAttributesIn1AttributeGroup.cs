namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
