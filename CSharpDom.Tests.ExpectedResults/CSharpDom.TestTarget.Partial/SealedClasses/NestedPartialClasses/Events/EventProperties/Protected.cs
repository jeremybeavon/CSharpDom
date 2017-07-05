namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedPartialClassWithProtectedEventProperty
    {
        public partial class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
