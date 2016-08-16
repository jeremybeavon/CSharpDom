using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedEnumMemberWithCodeAnalysis :
        AbstractNestedEnumMember<AttributeGroupWithCodeAnalysis, INestedEnum>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly NestedEnumWithCodeAnalysis declaringType;
        private readonly FieldDefinition field;
        private readonly Lazy<Attributes> attributes;

        internal NestedEnumMemberWithCodeAnalysis(NestedEnumWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, field));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override INestedEnum DeclaringType
        {
            get { return declaringType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        /*
        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedEnumMemberWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
