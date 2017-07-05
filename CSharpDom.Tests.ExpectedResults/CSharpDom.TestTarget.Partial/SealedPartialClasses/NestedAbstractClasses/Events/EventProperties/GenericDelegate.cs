namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate
    {
        public abstract class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
