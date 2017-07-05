namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedSealedClassWithPrivateEventProperty
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
