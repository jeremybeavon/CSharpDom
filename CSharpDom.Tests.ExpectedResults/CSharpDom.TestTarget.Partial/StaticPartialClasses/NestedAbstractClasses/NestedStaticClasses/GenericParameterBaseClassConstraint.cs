namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
