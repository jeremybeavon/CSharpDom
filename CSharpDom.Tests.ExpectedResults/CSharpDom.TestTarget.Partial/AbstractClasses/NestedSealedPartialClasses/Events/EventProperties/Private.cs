namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithPrivateEventProperty
    {
        public sealed partial class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
