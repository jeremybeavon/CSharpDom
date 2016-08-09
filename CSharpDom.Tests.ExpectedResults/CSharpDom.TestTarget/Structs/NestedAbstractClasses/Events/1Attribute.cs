namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events
{
    public struct StructWithNestedAbstractClassWithEventWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
