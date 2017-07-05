namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedSealedPartialClassWithPublicEventProperty
    {
        public sealed partial class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
