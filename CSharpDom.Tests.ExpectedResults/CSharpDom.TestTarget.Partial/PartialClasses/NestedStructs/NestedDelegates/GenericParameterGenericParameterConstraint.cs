namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedDelegates
{
    public partial class PartialClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
