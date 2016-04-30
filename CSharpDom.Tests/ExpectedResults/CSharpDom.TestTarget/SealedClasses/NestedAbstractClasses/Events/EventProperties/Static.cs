namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithStaticEventProperty
    {
        public abstract class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
