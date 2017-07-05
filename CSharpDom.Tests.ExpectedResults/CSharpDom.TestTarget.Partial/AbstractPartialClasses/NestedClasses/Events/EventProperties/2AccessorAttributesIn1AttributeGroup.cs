namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class
        {
            public event EventHandler Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
