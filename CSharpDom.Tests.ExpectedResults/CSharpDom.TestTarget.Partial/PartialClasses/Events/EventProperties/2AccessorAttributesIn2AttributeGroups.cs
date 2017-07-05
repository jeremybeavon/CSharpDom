namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
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
