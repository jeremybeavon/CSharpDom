namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedClassWithExplicitConversionOperator
    {
        public class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
