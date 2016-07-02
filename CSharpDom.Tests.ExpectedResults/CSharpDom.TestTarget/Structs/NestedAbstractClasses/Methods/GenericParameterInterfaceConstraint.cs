namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods
{
    public struct StructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
