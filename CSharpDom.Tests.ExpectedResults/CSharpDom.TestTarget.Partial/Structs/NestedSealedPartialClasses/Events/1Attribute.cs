namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events
{
    public struct StructWithNestedSealedPartialClassWithEventWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
