namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWith1Attribute
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
