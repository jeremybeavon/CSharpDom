namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
    {
        public sealed partial class Class
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
