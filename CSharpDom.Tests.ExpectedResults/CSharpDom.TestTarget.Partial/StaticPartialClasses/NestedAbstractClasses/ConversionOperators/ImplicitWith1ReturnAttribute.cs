namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.ConversionOperators
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public abstract class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
