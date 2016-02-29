using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
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

        internal NestedTypeReferenceWithMonoCecil(AssemblyWithMonoCecil assembly, TypeReference nestedType)
        {
            type = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, nestedType.DeclaringType);
            this.nestedType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, nestedType, ignoreNestedType: true);
        }

        public override ITypeReferenceWithMonoCecil NestedType
        {
            get { return nestedType; }
        }

        public override ITypeReferenceWithMonoCecil Type
        {
            get { return type; }
        }

        public TypeReference TypeReference
        {
            get { return nestedType.TypeReference; }
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
