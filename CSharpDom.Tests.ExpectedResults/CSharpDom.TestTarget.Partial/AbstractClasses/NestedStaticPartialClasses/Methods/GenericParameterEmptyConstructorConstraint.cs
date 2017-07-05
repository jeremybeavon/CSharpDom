namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
