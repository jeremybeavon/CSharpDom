namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public class Class
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
