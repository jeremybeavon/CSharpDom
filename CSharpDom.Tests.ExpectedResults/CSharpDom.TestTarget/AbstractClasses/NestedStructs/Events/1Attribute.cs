namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events
{
    public abstract class AbstractClassWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
