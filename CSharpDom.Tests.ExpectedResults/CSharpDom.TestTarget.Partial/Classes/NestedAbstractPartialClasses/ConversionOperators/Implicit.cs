namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.ConversionOperators
{
    public class ClassWithNestedAbstractPartialClassWithImplicitConversionOperator
    {
        public abstract partial class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
