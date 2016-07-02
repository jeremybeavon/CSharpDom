namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators
{
    public struct StructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            public static implicit operator Class([Attribute1][Attribute2]string text)
            {
                return default(Class);
            }
        }
    }
}
