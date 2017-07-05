namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedPartialClassWithProtectedEventProperty
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
