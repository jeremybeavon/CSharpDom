namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedClassWithNestedStructWithGenericParameterClassConstraint
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
