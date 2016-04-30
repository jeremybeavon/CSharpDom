namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
