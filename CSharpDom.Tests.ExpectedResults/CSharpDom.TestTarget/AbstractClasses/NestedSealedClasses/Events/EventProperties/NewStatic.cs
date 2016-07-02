namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithNewStaticEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
