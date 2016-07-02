namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates
{
    public struct StructWithNestedAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
