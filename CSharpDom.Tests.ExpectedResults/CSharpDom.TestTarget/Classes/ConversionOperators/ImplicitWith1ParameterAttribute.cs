namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator ClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(ClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
