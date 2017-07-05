namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events
{
    public abstract partial class AbstractPartialClassWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
