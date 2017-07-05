namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
