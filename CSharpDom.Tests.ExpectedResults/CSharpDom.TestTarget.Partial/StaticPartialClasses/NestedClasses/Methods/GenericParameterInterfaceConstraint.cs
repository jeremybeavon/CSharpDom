namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
