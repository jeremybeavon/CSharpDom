namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithPrivateEventProperty
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
