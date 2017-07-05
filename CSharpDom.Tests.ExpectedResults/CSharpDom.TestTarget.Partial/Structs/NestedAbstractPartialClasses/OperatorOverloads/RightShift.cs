namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.OperatorOverloads
{
    public struct StructWithNestedAbstractPartialClassWithRightShiftOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
