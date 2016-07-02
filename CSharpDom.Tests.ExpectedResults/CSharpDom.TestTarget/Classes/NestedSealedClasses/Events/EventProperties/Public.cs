namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties
{
    public class ClassWithNestedSealedClassWithPublicEventProperty
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
