namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
