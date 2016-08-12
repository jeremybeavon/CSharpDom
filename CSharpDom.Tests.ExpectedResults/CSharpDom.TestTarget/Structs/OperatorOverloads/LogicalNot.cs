namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithLogicalNotOperatorOverload
    {
        public static bool operator !(StructWithLogicalNotOperatorOverload parameter1)
        {
            return default(bool);
        }
    }
}
