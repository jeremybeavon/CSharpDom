namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
