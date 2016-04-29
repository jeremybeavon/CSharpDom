namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedClasses
{
    public class ClassWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
