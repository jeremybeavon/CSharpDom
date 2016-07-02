namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.ConversionOperators
{
    public class ClassWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
