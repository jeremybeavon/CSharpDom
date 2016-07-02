namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStructs
{
    public struct StructWithNestedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
