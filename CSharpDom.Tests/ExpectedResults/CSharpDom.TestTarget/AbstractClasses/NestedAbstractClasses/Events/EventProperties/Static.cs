namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithStaticEventProperty
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
