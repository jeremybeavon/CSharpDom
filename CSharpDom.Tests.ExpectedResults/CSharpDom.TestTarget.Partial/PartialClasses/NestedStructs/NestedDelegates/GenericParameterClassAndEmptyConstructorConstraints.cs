namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedDelegates
{
    public partial class PartialClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
