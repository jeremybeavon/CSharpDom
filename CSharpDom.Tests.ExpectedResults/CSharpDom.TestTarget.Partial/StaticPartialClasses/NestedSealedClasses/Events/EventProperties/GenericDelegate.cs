namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithEventPropertyWithGenericDelegate
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
