using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class StructNestedDelegate :
        IStructNestedDelegate<
            AttributeGroup,
            IStructType,
            GenericParameterDeclaration,
            TypeReference,
            DelegateParameter>
    {
        public StructNestedDelegate()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<DelegateParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public string Name { get; set; }
       
        public List<DelegateParameter> Parameters { get; set; }
        
        public TypeReference ReturnType { get; set; }
        
        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyList<DelegateParameter> IHasParameters<DelegateParameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedDelegate(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedDelegateChildren(this, visitor);
        }
    }
}
