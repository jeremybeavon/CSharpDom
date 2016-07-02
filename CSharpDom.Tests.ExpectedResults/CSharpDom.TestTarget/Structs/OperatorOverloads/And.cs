namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithAndOperator
    {
        public static StructWithAndOperator operator &(StructWithAndOperator parameter1, StructWithAndOperator parameter2)
        {
            return default(StructWithAndOperator);
        }
    }
}
