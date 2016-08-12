namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithMinusOperatorOverload
    {
        public static StructWithMinusOperatorOverload operator -(StructWithMinusOperatorOverload parameter1, StructWithMinusOperatorOverload parameter2)
        {
            return default(StructWithMinusOperatorOverload);
        }
    }
}
