namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.ConversionOperators
{
    public struct StructWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
