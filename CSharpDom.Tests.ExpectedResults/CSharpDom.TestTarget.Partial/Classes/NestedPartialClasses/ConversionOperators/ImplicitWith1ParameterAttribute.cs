namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.ConversionOperators
{
    public class ClassWithNestedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
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
