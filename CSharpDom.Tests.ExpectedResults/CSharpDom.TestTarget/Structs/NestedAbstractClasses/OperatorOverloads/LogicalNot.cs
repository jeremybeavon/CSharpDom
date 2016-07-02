namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads
{
    public struct StructWithNestedAbstractClassWithLogicalNotOperatorOverload
    {
        public abstract class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
