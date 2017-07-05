namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
