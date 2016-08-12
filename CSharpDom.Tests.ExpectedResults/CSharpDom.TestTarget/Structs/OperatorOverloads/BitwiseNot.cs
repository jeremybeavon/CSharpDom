namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithBitwiseNotOperatorOverload
    {
        public static StructWithBitwiseNotOperatorOverload operator ~(StructWithBitwiseNotOperatorOverload parameter1)
        {
            return default(StructWithBitwiseNotOperatorOverload);
        }
    }
}
