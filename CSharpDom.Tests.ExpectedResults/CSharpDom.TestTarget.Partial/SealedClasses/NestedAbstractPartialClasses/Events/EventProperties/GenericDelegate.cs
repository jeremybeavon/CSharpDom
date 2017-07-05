namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithEventPropertyWithGenericDelegate
    {
        public abstract partial class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
