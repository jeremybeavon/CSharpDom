namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public static partial class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static void Method()
            {
            }
        }
    }
}
