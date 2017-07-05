namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedPartialClassWithEventPropertyWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
