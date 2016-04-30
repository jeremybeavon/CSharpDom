namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStaticClasses
{
    public struct StructWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
