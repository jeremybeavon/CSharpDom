namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithPrivateEventProperty
    {
        public static partial class Class
        {
            private static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
