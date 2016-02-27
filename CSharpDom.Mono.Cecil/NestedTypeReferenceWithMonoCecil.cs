using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil
{
    public sealed class NestedTypeReferenceWithMonoCecil :
        AbstractNestedTypeReference<ITypeReferenceWithMonoCecil>,
        ITypeReferenceWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeReferenceWithMonoCecil type;
        private readonly ITypeReferenceWithMonoCecil nestedType;

        internal NestedTypeReferenceWithMonoCecil(Type nestedType)
        {
            type = TypeReferenceWithMonoCecilFactory.CreateReference(nestedType.DeclaringType);
            this.nestedType = TypeReferenceWithMonoCecilFactory.CreateReference(nestedType, ignoreNestedType: true);
        }

        public override ITypeReferenceWithMonoCecil NestedType
        {
            get { return nestedType; }
        }

        public override ITypeReferenceWithMonoCecil Type
        {
            get { return type; }
        }

        Type IHasType.Type
        {
            get { return nestedType.Type; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedTypeReferenceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
