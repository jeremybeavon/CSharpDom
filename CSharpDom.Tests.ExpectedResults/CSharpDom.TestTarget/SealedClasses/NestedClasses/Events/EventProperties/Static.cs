namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedClassWithStaticEventProperty
    {
        public class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
