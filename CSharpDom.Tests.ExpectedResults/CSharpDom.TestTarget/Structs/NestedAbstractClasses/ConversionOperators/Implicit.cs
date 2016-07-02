namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.ConversionOperators
{
    public struct StructWithNestedAbstractClassWithImplicitConversionOperator
    {
        public abstract class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
