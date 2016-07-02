namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(SealedClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(SealedClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
