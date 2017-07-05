namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedClasses
{
    public class ClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
