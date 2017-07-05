namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithEventPropertyWith1AccessorAttribute
    {
        public abstract partial class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
