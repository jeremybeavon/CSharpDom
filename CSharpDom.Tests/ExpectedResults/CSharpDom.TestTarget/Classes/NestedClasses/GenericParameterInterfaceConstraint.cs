namespace CSharpDom.TestTarget.Classes.NestedClasses
{
    public class ClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
