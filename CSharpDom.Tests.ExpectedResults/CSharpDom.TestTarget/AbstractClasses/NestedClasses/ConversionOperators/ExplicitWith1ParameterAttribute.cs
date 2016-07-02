namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute
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
