namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
