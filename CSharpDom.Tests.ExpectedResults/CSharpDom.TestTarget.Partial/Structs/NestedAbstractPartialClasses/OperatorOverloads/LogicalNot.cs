namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.OperatorOverloads
{
    public struct StructWithNestedAbstractPartialClassWithLogicalNotOperatorOverload
    {
        public abstract partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
