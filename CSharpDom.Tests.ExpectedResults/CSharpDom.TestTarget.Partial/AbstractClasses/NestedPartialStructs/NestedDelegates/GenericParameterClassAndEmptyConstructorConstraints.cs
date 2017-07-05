namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
