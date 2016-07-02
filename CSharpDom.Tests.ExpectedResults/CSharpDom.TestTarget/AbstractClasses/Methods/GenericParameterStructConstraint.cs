namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWithGenericParameterStructConstraint
    {
        public T Method<T>()
            where T : struct
        {
            return default(T);
        }
    }
}
