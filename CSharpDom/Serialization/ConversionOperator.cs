using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ConversionOperator : IConversionOperator<AttributeGroup, IType, TypeReference, Parameter, MethodBody>
    {
        public ConversionOperator()
        {
            Attributes = new List<AttributeGroup>();
            ReturnAttributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public ConversionOperatorType OperatorType { get; set; }

        public Parameter Parameter { get; set; }

        public List<AttributeGroup> ReturnAttributes { get; set; }

        public TypeReference ReturnType { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<AttributeGroup> IHasReturnAttributes<AttributeGroup>.ReturnAttributes
        {
            get { return ReturnAttributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConversionOperator(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConversionOperatorChildren(this, visitor);
        }
    }
}
