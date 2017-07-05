namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedPartialClassWithInternalEventProperty
    {
        public partial class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
