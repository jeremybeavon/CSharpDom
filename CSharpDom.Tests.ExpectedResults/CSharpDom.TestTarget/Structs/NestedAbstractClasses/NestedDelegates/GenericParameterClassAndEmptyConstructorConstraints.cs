namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates
{
    public struct StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
