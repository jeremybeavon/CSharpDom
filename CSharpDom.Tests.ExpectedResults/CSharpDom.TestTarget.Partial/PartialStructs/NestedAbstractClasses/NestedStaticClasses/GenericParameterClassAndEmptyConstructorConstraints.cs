namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
