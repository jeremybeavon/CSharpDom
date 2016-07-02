namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.ConversionOperators
{
    public class ClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public abstract class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
