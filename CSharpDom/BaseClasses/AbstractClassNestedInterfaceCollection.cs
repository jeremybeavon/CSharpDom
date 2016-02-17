using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassNestedInterfaceCollection<TInterface, TPartialInterface> :
        AbstractNestedInterfaceCollection<TInterface, TPartialInterface>,
        IClassNestedInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IClassNestedInterface
        where TPartialInterface : IPartialInterface
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedInterfaceCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedInterfaceCollectionChildren(this, visitor);
        }
    }
}
