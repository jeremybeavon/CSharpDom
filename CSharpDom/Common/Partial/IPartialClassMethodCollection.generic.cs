namespace CSharpDom.Common.Partial
{
    public interface IPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        IPartialClassMethodCollection,
        IClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IHasPartialMethodDefinitions<TPartialMethodDefinition>,
        IHasPartialMethodImplementations<TPartialMethodImplementation>
        where TMethod : IClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
    }
}
