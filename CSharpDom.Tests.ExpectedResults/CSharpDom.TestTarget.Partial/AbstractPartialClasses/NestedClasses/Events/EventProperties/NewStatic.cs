namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewStaticEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
