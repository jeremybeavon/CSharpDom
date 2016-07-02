namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads
{
    public struct StructWithNestedAbstractClassWithUnaryPlusOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
