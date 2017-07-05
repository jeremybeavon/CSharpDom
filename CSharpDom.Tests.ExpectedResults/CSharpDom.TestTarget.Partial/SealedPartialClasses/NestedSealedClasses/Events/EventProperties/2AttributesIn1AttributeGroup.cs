namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
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
