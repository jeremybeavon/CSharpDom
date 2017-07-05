namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
