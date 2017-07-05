namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
