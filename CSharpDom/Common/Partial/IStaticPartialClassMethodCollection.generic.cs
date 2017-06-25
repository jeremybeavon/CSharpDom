namespace CSharpDom.Common.Partial
{
    public interface IStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IStaticPartialClassMethodCollection,
        IStaticClassMethodCollection<TMethod, TExtensionMethod>,
        IHasPartialMethodDefinitions<TPartialMethodDefinition>,
        IHasPartialMethodImplementations<TPartialMethodImplementation>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
    }
}
