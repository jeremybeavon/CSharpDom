namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events
{
    public class ClassWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
