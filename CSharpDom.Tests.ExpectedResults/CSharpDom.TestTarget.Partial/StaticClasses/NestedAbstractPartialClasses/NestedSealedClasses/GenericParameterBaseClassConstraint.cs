namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
