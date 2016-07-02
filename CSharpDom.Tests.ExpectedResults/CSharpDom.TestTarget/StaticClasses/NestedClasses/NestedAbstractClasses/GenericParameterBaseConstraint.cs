namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
