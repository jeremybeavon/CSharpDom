namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
