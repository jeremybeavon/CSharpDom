namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
