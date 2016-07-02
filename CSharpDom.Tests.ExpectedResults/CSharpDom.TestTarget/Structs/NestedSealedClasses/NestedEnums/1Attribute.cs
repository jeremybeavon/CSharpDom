namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedEnums
{
    public struct StructWithNestedSealedClassWithNestedEnumWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public enum Enum
            {
            }
        }
    }
}
