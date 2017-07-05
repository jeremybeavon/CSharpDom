namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint
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
