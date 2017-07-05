namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedClassWithGenericParameterStructConstraint
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
