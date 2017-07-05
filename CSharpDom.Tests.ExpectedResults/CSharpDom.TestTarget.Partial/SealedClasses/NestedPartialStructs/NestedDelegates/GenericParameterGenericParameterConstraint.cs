namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
