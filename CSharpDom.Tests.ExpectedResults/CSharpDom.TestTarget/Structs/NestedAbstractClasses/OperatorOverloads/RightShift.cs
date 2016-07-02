namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads
{
    public struct StructWithNestedAbstractClassWithRightShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
