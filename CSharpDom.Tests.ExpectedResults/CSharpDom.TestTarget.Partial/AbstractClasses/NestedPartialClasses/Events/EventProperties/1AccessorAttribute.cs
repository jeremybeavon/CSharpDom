namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithEventPropertyWith1AccessorAttribute
    {
        public partial class Class
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
