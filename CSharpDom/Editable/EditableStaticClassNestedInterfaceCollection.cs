using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.Editable
{
    public abstract class EditableStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> :
        EditableNestedInterfaceCollection<TInterface, TPartialInterface>,
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
