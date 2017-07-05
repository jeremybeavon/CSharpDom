namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedDelegates
{
    public struct StructWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
