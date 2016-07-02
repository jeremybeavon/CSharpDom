namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint
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
