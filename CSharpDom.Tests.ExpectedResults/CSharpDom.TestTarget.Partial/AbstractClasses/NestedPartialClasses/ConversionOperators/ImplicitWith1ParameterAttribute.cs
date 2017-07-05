namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public partial class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
