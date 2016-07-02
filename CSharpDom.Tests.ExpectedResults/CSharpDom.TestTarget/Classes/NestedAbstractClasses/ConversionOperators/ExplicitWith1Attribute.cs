namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.ConversionOperators
{
    public class ClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
