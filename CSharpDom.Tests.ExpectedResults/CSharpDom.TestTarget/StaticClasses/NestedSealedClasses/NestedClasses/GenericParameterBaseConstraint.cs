namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
