namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStructs
{
    public struct StructWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint
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
