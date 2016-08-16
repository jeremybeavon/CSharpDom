using System;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterWithCodeAnalysis :
        AbstractGenericParameter<ITypeReferenceWithCodeAnalysis>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeReferenceWithCodeAnalysis typeReference;

        internal GenericParameterWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, TypeReference type)
        {
            typeReference = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, type, type);
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return typeReference; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
