namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithNewStaticEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
