namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup
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
