namespace CSharpDom.TestTarget.Classes.NestedClasses.ConversionOperators
{
    public class ClassWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute
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
