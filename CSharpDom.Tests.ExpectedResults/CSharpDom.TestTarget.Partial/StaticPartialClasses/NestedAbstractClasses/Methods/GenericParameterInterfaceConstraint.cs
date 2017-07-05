namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
