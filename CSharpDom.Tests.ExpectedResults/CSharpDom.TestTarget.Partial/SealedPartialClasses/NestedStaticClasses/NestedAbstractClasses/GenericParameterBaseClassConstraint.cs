namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
