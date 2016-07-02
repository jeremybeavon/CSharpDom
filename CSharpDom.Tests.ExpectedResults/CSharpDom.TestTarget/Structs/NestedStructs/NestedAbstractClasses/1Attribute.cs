namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public abstract class NestedClass
            {
            }
        }
    }
}
