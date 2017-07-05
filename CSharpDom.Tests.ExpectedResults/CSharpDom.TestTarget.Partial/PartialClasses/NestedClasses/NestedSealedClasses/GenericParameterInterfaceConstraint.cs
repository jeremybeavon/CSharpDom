namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
