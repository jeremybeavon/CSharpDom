namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.ConversionOperators
{
    public class ClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed partial class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
