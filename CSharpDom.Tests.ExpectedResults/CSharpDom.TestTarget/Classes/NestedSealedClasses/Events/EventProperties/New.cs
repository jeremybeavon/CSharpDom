namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties
{
    public class ClassWithNestedSealedClassWithNewEventProperty
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
