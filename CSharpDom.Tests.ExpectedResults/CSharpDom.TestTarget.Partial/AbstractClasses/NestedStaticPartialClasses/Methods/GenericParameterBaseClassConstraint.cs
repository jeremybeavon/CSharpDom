namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
