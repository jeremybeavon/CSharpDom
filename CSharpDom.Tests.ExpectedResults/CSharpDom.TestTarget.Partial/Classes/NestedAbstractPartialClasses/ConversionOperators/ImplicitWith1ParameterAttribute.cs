namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.ConversionOperators
{
    public class ClassWithNestedAbstractPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
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
