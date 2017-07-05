namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithEventPropertyWith1AccessorAttribute
    {
        public class Class
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
