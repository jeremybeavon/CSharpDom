namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups
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
