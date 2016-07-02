namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithEventPropertyWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
