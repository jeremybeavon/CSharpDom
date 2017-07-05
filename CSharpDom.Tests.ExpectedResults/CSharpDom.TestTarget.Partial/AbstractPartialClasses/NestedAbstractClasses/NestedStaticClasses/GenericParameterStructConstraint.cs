namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
