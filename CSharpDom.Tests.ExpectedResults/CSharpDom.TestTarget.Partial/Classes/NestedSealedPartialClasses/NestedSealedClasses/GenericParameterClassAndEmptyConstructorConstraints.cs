namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
