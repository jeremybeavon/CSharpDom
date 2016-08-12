namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithLeftShiftOperatorOverload
    {
        public static StructWithLeftShiftOperatorOverload operator <<(StructWithLeftShiftOperatorOverload parameter1, int parameter2)
        {
            return default(StructWithLeftShiftOperatorOverload);
        }
    }
}
