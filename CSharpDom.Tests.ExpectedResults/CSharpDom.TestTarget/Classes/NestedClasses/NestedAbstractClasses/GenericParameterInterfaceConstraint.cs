namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses
{
    public class ClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
