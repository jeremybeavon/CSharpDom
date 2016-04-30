namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
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
