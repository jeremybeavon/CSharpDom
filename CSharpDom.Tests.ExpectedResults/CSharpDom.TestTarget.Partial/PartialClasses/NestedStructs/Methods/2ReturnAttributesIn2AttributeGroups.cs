namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods
{
    public partial class PartialClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups
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
