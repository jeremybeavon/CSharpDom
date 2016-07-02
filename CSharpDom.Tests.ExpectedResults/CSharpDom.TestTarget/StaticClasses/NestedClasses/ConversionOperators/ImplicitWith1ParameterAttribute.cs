namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.ConversionOperators
{
    public static class StaticClassWithNestedClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
