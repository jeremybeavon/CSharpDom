namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
