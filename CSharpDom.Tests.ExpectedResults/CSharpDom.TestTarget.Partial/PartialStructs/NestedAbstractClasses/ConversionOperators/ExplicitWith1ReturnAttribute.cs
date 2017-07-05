namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute
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
