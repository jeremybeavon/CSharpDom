namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithPublicEventProperty
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
