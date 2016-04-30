namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint
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
