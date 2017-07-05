namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
