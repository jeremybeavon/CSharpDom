namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.ConversionOperators
{
    public class ClassWithNestedAbstractClassWithImplicitConversionOperator
    {
        public abstract class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
