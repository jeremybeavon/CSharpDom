namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithProtectedInternalEventProperty
    {
        public partial class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
