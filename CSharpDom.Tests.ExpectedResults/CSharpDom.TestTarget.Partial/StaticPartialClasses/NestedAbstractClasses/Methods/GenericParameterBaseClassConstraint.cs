namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
