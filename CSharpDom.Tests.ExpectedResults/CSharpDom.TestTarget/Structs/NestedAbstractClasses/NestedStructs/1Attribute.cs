namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStructs
{
    public struct StructWithNestedAbstractClassWithNestedStructWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
