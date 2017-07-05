namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events.EventProperties
{
    public class ClassWithNestedStaticPartialClassWithPrivateEventProperty
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
