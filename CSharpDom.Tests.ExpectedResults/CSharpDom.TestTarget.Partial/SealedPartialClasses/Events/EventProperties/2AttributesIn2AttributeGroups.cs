namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
