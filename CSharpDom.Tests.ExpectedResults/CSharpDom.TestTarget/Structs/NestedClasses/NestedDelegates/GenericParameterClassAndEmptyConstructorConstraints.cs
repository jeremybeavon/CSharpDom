namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedDelegates
{
    public struct StructWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
