namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.ConversionOperators
{
    public partial class PartialClassWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
