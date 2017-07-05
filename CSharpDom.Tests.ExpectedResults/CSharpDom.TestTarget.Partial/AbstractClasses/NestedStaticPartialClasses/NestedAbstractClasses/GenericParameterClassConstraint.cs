namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
