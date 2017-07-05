namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
