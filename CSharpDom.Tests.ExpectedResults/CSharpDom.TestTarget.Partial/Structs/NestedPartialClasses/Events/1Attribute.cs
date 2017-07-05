namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events
{
    public struct StructWithNestedPartialClassWithEventWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
