namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
