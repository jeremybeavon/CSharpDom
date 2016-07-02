namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedDelegates
{
    public struct StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
