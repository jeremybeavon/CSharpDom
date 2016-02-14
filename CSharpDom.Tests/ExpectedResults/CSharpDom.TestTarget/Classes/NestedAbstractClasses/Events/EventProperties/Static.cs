namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithStaticEventProperty
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
