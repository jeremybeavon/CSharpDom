namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
