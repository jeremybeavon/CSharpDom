namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
