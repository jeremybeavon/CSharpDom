namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
