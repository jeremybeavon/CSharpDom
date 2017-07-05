namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
