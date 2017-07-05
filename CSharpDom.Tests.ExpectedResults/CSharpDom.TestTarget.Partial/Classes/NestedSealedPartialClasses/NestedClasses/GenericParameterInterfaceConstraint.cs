namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
