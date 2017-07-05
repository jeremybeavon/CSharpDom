namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedAbstractClassWithLeftShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
