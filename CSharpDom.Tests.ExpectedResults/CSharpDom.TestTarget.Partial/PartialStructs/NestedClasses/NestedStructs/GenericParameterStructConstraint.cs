namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedClassWithNestedStructWithGenericParameterStructConstraint
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
