namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods
{
    public static class StaticClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
