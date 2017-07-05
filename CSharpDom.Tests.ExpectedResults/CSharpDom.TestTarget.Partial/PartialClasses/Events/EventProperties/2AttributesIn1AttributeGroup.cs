namespace CSharpDom.TestTarget.Partial.PartialClasses.Events.EventProperties
{
    public partial class PartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
