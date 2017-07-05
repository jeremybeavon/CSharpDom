namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
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
