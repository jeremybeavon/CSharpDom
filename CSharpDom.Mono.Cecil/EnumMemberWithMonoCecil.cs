using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class EnumMemberWithMonoCecil :
        AbstractEnumMember<AttributeWithMonoCecil, EnumWithMonoCecil>,
        IHasFieldDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly EnumWithMonoCecil declaringType;
        private readonly FieldDefinition field;
        private readonly Lazy<Attributes> attributes;

        internal EnumMemberWithMonoCecil(EnumWithMonoCecil declaringType, FieldDefinition field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, field));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override EnumWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        public FieldDefinition FieldDefinition
        {
            get { return field; }
        }


        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumMemberWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
