namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
