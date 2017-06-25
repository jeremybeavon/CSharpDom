namespace CSharpDom.Common.Partial
{
    public interface INestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        INestedStaticPartialClassMethodCollection,
        INestedStaticClassMethodCollection<TMethod>,
        IHasPartialMethodDefinitions<TPartialMethodDefinition>,
        IHasPartialMethodImplementations<TPartialMethodImplementation>
        where TMethod : IStaticClassMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
    }
}
