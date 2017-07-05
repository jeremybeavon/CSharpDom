namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
