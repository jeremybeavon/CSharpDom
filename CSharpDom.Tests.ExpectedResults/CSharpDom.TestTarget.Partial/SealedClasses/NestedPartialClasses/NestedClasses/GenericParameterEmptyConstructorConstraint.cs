namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
