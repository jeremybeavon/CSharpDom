namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedClassWithExplicitConversionOperatorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
