namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
