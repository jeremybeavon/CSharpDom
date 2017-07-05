namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStructs
{
    public struct StructWithNestedAbstractPartialClassWithNestedStructWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
