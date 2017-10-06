using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Partial
{
    public abstract class EditablePartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> :
        AbstractGenericVisitableObject,
        IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract TMethodBody Body { get; set; }

        public abstract string Name { get; set; }

        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract ICollection<TAttributeGroup> ReturnAttributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract IList<TGenericParameter> GenericParameters { get; set; }

        public abstract IList<TParameter> Parameters { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes =>
            new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes);

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters =>
            new ReadOnlyCollection<TGenericParameter>(GenericParameters);

        IReadOnlyCollection<TAttributeGroup> IHasReturnAttributes<TAttributeGroup>.ReturnAttributes =>
            new ReadOnlyCollectionWrapper<TAttributeGroup>(ReturnAttributes);

        IReadOnlyList<TParameter> IHasParameters<TParameter>.Parameters =>
            new ReadOnlyCollection<TParameter>(Parameters);

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialMethodImplementation(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialMethodImplementationChildren(this, visitor);
        }
    }
}
