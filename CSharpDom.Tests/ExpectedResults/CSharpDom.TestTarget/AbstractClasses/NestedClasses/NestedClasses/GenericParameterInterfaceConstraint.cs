namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint
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
