namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithExclusiveOrOperatorOverload
    {
        public static SealedClassWithExclusiveOrOperatorOverload operator ^(SealedClassWithExclusiveOrOperatorOverload parameter1, SealedClassWithExclusiveOrOperatorOverload parameter2)
        {
            return default(SealedClassWithExclusiveOrOperatorOverload);
        }
    }
}
