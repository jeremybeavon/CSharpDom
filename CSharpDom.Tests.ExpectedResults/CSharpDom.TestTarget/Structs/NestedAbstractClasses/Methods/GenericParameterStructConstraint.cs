namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods
{
    public struct StructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
