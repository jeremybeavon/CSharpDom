namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedPartialClassWithPrivateEventProperty
    {
        public partial class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
