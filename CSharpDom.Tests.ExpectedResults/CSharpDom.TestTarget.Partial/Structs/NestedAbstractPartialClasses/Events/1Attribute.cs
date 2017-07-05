namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events
{
    public struct StructWithNestedAbstractPartialClassWithEventWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
