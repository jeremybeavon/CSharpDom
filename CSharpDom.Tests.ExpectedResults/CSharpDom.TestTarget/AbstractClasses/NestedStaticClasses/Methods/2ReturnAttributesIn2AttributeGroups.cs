namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public static class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static void Method()
            {
            }
        }
    }
}
