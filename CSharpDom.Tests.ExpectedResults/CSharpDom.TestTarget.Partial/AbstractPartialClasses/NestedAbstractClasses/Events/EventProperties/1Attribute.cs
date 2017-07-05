namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithEventPropertyWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
