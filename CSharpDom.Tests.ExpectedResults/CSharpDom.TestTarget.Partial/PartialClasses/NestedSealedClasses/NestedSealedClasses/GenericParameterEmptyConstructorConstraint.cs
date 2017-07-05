namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
