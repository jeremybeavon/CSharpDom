namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup
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
