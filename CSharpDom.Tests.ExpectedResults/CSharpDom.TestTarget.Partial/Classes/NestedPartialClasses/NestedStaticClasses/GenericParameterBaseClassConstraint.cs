namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
