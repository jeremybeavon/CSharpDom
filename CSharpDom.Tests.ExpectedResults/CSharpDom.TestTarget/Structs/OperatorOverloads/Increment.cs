namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithIncrementOperatorOverload
    {
        public static StructWithIncrementOperatorOverload operator ++(StructWithIncrementOperatorOverload parameter1)
        {
            return default(StructWithIncrementOperatorOverload);
        }
    }
}
