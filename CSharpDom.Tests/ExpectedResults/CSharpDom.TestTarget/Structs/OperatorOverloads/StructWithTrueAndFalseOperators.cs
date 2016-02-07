namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithTrueAndFalseOperators
    {
        public static bool operator true(StructWithTrueAndFalseOperators parameter1)
        {
            return default(bool);
        }

        public static bool operator false(StructWithTrueAndFalseOperators parameter1)
        {
            return default(bool);
        }
    }
}
