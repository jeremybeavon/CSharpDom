namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
