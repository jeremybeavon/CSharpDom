namespace CSharpDom.TestTarget.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
