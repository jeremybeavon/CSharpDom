namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithExclusiveOrOperator
    {
        public static StructWithExclusiveOrOperator operator ^(StructWithExclusiveOrOperator parameter1, StructWithExclusiveOrOperator parameter2)
        {
            return parameter1;
        }
    }
}
