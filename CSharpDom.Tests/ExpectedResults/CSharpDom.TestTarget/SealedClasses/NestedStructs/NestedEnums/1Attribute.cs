namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedEnums
{
    public sealed class SealedClassWithNestedStructWithNestedEnumWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public enum Enum
            {
            }
        }
    }
}
