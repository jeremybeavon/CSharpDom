namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithPlusOperatorOverload
    {
        public static SealedClassWithPlusOperatorOverload operator +(SealedClassWithPlusOperatorOverload parameter1, SealedClassWithPlusOperatorOverload parameter2)
        {
            return default(SealedClassWithPlusOperatorOverload);
        }
    }
}
