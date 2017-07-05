namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedDelegates
{
    public struct StructWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
