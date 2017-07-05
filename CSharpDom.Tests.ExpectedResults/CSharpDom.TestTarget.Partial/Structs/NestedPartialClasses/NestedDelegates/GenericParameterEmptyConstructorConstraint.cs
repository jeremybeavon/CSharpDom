namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedDelegates
{
    public struct StructWithNestedPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
