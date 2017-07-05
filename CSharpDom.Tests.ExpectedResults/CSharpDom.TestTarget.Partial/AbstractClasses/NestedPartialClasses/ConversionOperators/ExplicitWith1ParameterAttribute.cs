namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public partial class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
