namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
