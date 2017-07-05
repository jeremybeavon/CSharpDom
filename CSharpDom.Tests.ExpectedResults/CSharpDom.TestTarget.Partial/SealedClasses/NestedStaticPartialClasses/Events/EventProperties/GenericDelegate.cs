namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithEventPropertyWithGenericDelegate
    {
        public static partial class Class
        {
            public static event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
