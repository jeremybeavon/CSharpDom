namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
