namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStructs
{
    public partial class PartialClassWithNestedClassWithNestedStructWithGenericParameterStructConstraint
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
