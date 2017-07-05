namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract partial class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
