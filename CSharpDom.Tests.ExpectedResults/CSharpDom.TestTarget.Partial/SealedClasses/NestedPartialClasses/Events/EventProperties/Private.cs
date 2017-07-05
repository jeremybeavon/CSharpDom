namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedPartialClassWithPrivateEventProperty
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
