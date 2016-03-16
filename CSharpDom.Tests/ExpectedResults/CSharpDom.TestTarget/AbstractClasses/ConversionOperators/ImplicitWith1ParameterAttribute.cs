namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
