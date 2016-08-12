namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithOrOperatorOverload
    {
        public static StructWithOrOperatorOverload operator |(StructWithOrOperatorOverload parameter1, StructWithOrOperatorOverload parameter2)
        {
            return default(StructWithOrOperatorOverload);
        }
    }
}
