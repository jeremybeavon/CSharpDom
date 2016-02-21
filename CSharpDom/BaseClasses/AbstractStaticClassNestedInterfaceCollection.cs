using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> :
        AbstractNestedInterfaceCollection<TInterface, TPartialInterface>,
        IStaticClassNestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IStaticClassNestedInterface
        where TPartialInterface : IPartialInterface
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedInterfaceCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedInterfaceCollectionChildren(this, visitor);
        }
    }
}
