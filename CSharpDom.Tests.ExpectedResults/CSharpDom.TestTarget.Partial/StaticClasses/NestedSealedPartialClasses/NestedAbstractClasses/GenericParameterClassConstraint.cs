namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
