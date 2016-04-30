namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
