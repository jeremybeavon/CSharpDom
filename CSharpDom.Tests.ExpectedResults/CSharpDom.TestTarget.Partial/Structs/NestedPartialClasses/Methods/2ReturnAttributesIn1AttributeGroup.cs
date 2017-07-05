namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
