namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
