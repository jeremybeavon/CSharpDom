namespace CSharpDom.TestTarget.Classes.NestedClasses.ConversionOperators
{
    public class ClassWithNestedClassWithImplicitConversionOperatorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
