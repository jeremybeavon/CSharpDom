namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
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
