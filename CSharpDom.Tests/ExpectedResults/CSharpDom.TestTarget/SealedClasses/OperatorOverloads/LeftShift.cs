namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithLeftShiftOperatorOverload
    {
        public static SealedClassWithLeftShiftOperatorOverload operator <<(SealedClassWithLeftShiftOperatorOverload parameter1, int parameter2)
        {
            return default(SealedClassWithLeftShiftOperatorOverload);
        }
    }
}
