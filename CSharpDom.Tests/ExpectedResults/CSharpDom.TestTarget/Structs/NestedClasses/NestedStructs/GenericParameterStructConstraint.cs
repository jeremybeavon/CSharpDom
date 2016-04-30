namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStructs
{
    public struct StructWithNestedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
