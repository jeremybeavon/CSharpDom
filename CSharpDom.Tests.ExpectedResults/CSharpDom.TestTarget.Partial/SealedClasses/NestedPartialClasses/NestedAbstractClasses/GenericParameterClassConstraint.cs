namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
