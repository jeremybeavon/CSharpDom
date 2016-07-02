namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
