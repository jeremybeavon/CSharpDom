namespace CSharpDom.TestTarget.Classes.NestedClasses.ConversionOperators
{
    public class ClassWithNestedClassWithImplicitConversionOperator
    {
        public class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
