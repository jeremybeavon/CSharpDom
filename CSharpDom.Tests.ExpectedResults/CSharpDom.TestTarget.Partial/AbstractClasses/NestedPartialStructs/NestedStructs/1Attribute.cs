namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithNestedStructWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
