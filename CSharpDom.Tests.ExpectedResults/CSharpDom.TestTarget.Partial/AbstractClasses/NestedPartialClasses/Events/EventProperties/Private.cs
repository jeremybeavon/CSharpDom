namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithPrivateEventProperty
    {
        public partial class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
