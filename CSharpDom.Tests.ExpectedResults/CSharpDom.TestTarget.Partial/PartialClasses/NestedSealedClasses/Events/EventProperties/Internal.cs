namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedSealedClassWithInternalEventProperty
    {
        public sealed class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
