namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedDelegates
{
    public struct StructWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
