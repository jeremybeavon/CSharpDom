namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(StructWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(StructWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
