namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStructs
{
    public static class StaticClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
