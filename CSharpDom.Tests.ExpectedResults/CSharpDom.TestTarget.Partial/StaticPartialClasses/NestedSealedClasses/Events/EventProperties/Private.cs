namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithPrivateEventProperty
    {
        public sealed class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
