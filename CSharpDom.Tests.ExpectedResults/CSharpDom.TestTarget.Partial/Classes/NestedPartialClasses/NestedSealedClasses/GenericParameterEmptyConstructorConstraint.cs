namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
