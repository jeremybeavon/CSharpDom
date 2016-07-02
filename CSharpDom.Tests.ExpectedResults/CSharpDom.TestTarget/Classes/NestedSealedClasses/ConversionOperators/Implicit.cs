namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.ConversionOperators
{
    public class ClassWithNestedSealedClassWithImplicitConversionOperator
    {
        public sealed class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
