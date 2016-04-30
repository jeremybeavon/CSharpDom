namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStructWithNestedAbstractClassWith1Attribute
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
