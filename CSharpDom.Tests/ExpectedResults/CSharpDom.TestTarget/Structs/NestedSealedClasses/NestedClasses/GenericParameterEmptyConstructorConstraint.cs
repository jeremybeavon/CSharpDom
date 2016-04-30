namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedClasses
{
    public struct StructWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
