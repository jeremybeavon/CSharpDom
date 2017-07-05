namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
