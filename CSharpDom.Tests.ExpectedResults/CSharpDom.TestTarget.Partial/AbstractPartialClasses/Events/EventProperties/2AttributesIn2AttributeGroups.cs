namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
