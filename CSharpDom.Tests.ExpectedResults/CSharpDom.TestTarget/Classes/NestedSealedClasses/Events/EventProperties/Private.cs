namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties
{
    public class ClassWithNestedSealedClassWithPrivateEventProperty
    {
        public sealed class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
