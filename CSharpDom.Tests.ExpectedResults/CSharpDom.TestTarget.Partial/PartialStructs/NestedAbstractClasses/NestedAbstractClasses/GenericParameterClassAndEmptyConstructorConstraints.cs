namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
