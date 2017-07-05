namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
