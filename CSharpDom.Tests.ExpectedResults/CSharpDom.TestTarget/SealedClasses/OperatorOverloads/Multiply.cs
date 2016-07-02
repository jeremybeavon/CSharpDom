namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithMultiplyOperatorOverload
    {
        public static SealedClassWithMultiplyOperatorOverload operator *(SealedClassWithMultiplyOperatorOverload parameter1, SealedClassWithMultiplyOperatorOverload parameter2)
        {
            return default(SealedClassWithMultiplyOperatorOverload);
        }
    }
}
