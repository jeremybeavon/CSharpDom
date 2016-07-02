namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.ConversionOperators
{
    public static class StaticClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public abstract class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
