namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
