namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
