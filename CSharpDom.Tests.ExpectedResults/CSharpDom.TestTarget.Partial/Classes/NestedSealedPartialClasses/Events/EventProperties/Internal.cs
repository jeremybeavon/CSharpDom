namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedSealedPartialClassWithInternalEventProperty
    {
        public sealed partial class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
