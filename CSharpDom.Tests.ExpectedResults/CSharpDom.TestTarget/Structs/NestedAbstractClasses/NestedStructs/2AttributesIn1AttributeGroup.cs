namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStructs
{
    public struct StructWithNestedAbstractClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
