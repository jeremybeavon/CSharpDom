namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedSealedPartialClassWithNewStaticEventProperty
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
