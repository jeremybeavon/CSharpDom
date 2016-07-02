namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties
{
    public class ClassWithNestedSealedClassWithStaticEventProperty
    {
        public sealed class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
