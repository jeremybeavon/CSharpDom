namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.ConversionOperators
{
    public class ClassWithNestedAbstractClassWithExplicitConversionOperator
    {
        public abstract class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
