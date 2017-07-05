namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events.EventProperties
{
    public class ClassWithNestedStaticPartialClassWithInternalEventProperty
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
