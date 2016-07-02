namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates
{
    public struct StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
