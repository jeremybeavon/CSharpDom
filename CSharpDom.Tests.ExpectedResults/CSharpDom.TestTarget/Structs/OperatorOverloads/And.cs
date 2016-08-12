namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithAndOperatorOverload
    {
        public static StructWithAndOperatorOverload operator &(StructWithAndOperatorOverload parameter1, StructWithAndOperatorOverload parameter2)
        {
            return default(StructWithAndOperatorOverload);
        }
    }
}
