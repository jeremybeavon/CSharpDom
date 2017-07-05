namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithVirtualEventProperty
    {
        public partial class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
