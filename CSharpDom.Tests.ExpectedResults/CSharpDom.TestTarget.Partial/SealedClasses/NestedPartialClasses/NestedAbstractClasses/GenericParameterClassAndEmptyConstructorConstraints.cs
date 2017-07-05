namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
