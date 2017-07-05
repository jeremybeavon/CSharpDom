namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed partial class Class
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
