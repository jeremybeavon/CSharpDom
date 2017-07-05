namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedClasses
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
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
