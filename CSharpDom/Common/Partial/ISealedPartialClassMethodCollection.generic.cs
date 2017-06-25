namespace CSharpDom.Common.Partial
{
    public interface ISealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> :
        ISealedPartialClassMethodCollection,
        ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IHasPartialMethodDefinitions<TPartialMethodDefinition>,
        IHasPartialMethodImplementations<TPartialMethodImplementation>
        where TMethod : ISealedClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TPartialMethodDefinition : IPartialMethodDefinition
        where TPartialMethodImplementation : IPartialMethodImplementation
    {
    }
}
