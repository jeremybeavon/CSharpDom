namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithProtectedEventProperty
    {
        public sealed class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
