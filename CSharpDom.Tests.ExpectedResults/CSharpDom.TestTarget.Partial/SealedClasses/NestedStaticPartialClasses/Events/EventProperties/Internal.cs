namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithInternalEventProperty
    {
        public static partial class Class
        {
            internal static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
