namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
