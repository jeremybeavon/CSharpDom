namespace CSharpDom.TestTarget.Classes.NestedStructs.Methods
{
    public class ClassWithNestedStructWithMethodWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
