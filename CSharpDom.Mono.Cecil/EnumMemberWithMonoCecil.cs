using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class EnumMemberWithMonoCecil :
        AbstractEnumMember<AttributeWithMonoCecil, EnumWithMonoCecil>,
        IHasFieldInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly EnumWithMonoCecil declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;

        internal EnumMemberWithMonoCecil(EnumWithMonoCecil declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
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

        public FieldInfo FieldInfo
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
