namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithLogicalNotOperator
    {
        public static bool operator !(StructWithLogicalNotOperator parameter1)
        {
            return default(bool);
        }
    }
}
