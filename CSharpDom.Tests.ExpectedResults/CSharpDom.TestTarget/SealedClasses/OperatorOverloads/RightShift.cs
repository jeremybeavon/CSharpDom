namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithRightShiftOperatorOverload
    {
        public static SealedClassWithRightShiftOperatorOverload operator >>(SealedClassWithRightShiftOperatorOverload parameter1, int parameter2)
        {
            return default(SealedClassWithRightShiftOperatorOverload);
        }
    }
}
