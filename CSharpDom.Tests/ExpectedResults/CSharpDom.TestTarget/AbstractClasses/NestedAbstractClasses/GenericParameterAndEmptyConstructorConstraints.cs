namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
