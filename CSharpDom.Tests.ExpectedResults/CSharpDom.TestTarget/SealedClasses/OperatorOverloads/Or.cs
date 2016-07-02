namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithOrOperatorOverload
    {
        public static SealedClassWithOrOperatorOverload operator |(SealedClassWithOrOperatorOverload parameter1, SealedClassWithOrOperatorOverload parameter2)
        {
            return default(SealedClassWithOrOperatorOverload);
        }
    }
}
