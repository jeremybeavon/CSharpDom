namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
