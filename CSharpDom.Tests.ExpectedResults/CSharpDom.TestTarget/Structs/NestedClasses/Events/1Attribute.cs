namespace CSharpDom.TestTarget.Structs.NestedClasses.Events
{
    public struct StructWithNestedClassWithEventWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
