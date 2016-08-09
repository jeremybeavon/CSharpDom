namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events
{
    public struct StructWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
