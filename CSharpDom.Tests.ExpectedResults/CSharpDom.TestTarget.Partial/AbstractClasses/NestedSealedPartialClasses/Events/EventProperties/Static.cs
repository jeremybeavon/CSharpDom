namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithStaticEventProperty
    {
        public sealed partial class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
