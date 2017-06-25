namespace CSharpDom.Common.Partial
{
    public interface IAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IAbstractPartialClassMethodCollection,
        IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>,
        IHasPartialMethodDefinitions<TPartialMethodDefinition>,
        IHasPartialMethodImplementations<TPartialMethodImplementation>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
    }
}
