namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
