namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
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
