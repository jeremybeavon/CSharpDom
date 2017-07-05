namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
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
