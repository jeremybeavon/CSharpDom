namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
