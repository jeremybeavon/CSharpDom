namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses
{
    public class ClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
