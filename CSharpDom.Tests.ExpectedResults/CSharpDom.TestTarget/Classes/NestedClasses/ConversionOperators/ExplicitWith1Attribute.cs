namespace CSharpDom.TestTarget.Classes.NestedClasses.ConversionOperators
{
    public class ClassWithNestedClassWithExplicitConversionOperatorWith1Attribute
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
