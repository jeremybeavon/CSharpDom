namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
