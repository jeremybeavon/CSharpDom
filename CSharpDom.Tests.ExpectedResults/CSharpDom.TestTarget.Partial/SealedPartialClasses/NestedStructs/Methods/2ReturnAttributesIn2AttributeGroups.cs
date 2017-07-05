namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods
{
    public sealed partial class SealedPartialClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
