namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWith1ReturnAttribute
    {
        public struct Struct
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
