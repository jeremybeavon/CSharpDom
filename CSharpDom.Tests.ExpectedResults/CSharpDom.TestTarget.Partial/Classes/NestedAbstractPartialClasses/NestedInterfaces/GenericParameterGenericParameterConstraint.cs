namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
