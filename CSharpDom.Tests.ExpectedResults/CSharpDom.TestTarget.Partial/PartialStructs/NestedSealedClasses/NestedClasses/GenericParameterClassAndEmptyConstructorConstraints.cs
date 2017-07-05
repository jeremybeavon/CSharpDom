namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
