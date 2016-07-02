namespace CSharpDom.TestTarget.Structs.NestedClasses.Methods
{
    public struct StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
