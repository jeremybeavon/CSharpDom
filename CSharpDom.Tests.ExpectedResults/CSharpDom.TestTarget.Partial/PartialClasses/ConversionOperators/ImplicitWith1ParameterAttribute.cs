namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator PartialClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(PartialClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
