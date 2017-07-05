namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
