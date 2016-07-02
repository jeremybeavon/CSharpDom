namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses
{
    public struct StructWithNestedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
