namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
