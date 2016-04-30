namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
