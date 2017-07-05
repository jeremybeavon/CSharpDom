namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithProtectedEventProperty
    {
        public sealed partial class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
