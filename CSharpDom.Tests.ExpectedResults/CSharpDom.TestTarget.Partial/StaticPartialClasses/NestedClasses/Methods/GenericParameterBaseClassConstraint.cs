namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
