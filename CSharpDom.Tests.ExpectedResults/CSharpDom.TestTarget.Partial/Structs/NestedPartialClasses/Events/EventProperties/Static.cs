namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedPartialClassWithStaticEventProperty
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
