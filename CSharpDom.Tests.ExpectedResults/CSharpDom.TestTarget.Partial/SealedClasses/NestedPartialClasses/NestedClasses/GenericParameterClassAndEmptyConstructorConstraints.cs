namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
