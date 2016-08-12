namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithMultiplyOperatorOverload
    {
        public static StructWithMultiplyOperatorOverload operator *(StructWithMultiplyOperatorOverload parameter1, StructWithMultiplyOperatorOverload parameter2)
        {
            return default(StructWithMultiplyOperatorOverload);
        }
    }
}
