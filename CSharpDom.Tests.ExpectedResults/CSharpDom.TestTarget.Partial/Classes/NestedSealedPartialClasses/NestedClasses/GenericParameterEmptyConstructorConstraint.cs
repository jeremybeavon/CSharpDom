namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
