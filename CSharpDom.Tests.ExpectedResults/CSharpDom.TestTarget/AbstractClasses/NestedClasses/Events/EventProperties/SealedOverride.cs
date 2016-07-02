namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithSealedOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
