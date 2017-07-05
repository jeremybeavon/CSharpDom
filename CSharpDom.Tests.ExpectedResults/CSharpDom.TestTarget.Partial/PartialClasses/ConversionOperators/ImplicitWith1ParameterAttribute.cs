namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator ClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(ClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
