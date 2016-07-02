namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithOrOperator
    {
        public static StructWithOrOperator operator |(StructWithOrOperator parameter1, StructWithOrOperator parameter2)
        {
            return default(StructWithOrOperator);
        }
    }
}
