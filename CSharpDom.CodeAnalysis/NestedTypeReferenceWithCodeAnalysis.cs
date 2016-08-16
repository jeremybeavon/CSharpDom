using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedTypeReferenceWithCodeAnalysis :
        AbstractNestedTypeReference<ITypeReferenceWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeReferenceWithCodeAnalysis type;
        private readonly ITypeReferenceWithCodeAnalysis nestedType;

        internal NestedTypeReferenceWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, TypeReference nestedType)
        {
            type = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, nestedType.DeclaringType);
            this.nestedType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, nestedType, ignoreNestedType: true);
        }

        public override ITypeReferenceWithCodeAnalysis NestedType
        {
            get { return nestedType; }
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type; }
        }

        public TypeReference TypeReference
        {
            get { return nestedType.TypeReference; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedTypeReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
