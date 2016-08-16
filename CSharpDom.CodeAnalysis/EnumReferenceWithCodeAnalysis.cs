using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EnumReferenceWithCodeAnalysis :
        AbstractEnumReference,
        ITypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;

        internal EnumReferenceWithCodeAnalysis(TypeReference type)
        {
            this.type = type;
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public TypeReference TypeReference
        {
            get { return type; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
