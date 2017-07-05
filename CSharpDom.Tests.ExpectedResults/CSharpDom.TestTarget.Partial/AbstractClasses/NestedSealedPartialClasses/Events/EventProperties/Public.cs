namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithPublicEventProperty
    {
        public sealed partial class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
