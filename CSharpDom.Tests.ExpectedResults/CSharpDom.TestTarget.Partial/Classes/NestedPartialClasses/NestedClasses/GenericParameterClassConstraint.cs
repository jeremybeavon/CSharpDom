namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedClasses
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
