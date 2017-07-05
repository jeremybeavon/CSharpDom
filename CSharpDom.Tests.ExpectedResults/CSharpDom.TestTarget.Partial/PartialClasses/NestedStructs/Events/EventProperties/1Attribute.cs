namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.EventProperties
{
    public partial class PartialClassWithNestedStructWithEventPropertyWith1Attribute
    {
        public struct Struct
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
