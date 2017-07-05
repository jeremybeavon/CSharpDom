namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
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
