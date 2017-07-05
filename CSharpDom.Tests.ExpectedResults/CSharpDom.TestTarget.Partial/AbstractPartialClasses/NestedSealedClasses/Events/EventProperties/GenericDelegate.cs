namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithEventPropertyWithGenericDelegate
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
