namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedPartialClassWithStaticEventProperty
    {
        public partial class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
