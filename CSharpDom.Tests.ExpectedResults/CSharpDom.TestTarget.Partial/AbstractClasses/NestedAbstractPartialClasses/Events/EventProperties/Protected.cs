namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithProtectedEventProperty
    {
        public abstract partial class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
