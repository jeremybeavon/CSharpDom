namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithStaticEventProperty
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
