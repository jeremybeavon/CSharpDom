namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses
{
    public struct StructWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint
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
