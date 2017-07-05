namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
