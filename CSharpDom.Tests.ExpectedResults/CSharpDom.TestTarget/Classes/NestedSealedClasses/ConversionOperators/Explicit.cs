namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.ConversionOperators
{
    public class ClassWithNestedSealedClassWithExplicitConversionOperator
    {
        public sealed class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
