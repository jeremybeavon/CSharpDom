namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
