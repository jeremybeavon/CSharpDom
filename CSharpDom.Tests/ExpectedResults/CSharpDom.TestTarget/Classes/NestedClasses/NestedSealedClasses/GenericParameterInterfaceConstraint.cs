namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedSealedClasses
{
    public class ClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
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
