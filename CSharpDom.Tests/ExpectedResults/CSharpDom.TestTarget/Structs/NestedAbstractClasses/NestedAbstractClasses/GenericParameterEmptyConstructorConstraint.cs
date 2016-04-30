namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
