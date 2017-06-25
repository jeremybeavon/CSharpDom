using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable.Partial
{
    public abstract class EditablePartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> :
        IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TParameter : IMethodParameter
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        public abstract IList<TGenericParameter> GenericParameters { get; set; }
        
        public abstract string Name { get; set; }

        public abstract IList<TParameter> Parameters { get; }

        public abstract ICollection<TAttributeGroup> ReturnAttributes { get; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes =>
            new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes);

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters =>
            new ReadOnlyCollection<TGenericParameter>(GenericParameters);

        IReadOnlyCollection<TAttributeGroup> IHasReturnAttributes<TAttributeGroup>.ReturnAttributes =>
            new ReadOnlyCollectionWrapper<TAttributeGroup>(ReturnAttributes);

        IReadOnlyList<TParameter> IHasParameters<TParameter>.Parameters =>
            new ReadOnlyCollection<TParameter>(Parameters);

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialMethodDefinition(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialMethodDefinitionChildren(this, visitor);
        }
    }
}
