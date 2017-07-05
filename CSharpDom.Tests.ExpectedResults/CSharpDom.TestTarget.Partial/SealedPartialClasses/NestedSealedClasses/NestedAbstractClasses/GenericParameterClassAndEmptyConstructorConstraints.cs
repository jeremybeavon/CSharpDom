namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
