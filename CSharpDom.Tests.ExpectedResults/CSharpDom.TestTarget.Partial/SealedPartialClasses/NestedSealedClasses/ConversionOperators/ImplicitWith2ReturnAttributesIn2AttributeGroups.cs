namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
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
