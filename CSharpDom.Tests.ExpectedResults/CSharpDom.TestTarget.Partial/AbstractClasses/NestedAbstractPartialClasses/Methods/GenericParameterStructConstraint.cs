namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
