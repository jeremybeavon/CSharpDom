namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
