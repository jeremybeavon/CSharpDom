namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
