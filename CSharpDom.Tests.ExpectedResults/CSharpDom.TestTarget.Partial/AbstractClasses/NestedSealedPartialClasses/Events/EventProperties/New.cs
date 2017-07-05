namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
