namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events
{
    public partial class PartialClassWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
