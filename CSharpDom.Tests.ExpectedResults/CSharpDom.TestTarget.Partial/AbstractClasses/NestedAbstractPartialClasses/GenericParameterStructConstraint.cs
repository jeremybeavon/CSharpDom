namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
