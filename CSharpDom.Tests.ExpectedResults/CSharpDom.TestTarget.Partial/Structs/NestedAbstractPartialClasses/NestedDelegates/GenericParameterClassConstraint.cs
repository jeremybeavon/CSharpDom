namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedDelegates
{
    public struct StructWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
