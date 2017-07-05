namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
