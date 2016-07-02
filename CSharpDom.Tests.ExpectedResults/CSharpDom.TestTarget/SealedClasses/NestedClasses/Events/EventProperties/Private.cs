namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedClassWithPrivateEventProperty
    {
        public class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
