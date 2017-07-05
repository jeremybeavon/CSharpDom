namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedClasses
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
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
