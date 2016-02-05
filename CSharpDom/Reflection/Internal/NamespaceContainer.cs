namespace CSharpDom.Reflection.Internal
{
    internal sealed class NamespaceContainer
    {
        public NamespaceContainer(string name)
        {
            TypeContainer = new TypeContainer();
            Namespace = new NamespaceWithReflection(name, TypeContainer);
        }

        public NamespaceWithReflection Namespace { get; private set; }

        public TypeContainer TypeContainer { get; private set; }
    }
}
