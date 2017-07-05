namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class<T>
            where T : BaseClass
        {
        }
    }
}
