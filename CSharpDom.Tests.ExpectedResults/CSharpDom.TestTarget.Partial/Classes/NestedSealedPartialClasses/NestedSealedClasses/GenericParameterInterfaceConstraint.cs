namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
