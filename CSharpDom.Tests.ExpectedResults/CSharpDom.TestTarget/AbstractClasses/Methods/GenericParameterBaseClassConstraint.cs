namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWithGenericParameterBaseAbstractClassConstraint
    {
        public T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}
