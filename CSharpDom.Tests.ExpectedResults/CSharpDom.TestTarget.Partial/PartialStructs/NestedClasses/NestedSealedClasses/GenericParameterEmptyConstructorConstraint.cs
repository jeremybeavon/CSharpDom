namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
