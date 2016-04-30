namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public void Method()
            {
            }
        }
    }
}
