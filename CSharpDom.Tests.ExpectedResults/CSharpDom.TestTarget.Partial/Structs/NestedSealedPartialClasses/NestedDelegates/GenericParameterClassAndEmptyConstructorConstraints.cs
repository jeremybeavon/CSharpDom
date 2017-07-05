namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedDelegates
{
    public struct StructWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
