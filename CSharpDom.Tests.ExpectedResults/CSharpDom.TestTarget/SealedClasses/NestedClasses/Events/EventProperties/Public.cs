namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedClassWithPublicEventProperty
    {
        public class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
