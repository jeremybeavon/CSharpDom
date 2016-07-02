namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithMinusOperatorOverload
    {
        public static SealedClassWithMinusOperatorOverload operator -(SealedClassWithMinusOperatorOverload parameter1, SealedClassWithMinusOperatorOverload parameter2)
        {
            return default(SealedClassWithMinusOperatorOverload);
        }
    }
}
