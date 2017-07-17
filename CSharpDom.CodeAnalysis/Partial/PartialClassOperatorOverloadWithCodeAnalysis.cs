using CSharpDom.Common;
using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassOperatorOverloadWithCodeAnalysis :
        EditableOperatorOverload<
            AttributeGroupWithCodeAnalysis,
            IPartialClassTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<OperatorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassOperatorOverloadWithCodeAnalysis operatorOverload;
        
        internal PartialClassOperatorOverloadWithCodeAnalysis(ClassOperatorOverloadWithCodeAnalysis operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }

        public OperatorOverloadWithCodeAnalysis OperatorOverload
        {
            get { return operatorOverload.OperatorOverload; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return operatorOverload.Attributes; }
            set { operatorOverload.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return operatorOverload.Body; }
            set { operatorOverload.Body = value; }
        }

        public override IPartialClassTypeWithCodeAnalysis DeclaringType
        {
            get { return operatorOverload.OperatorOverload.Node.GetParentNode<IPartialClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorOverload.OperatorType; }
            set { operatorOverload.OperatorType = value; }
        }

        public override IList<OperatorParameterWithCodeAnalysis> Parameters
        {
            get { return operatorOverload.Parameters; }
            set { operatorOverload.Parameters = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return operatorOverload.ReturnType; }
            set { operatorOverload.ReturnType = value; }
        }
        
        public OperatorDeclarationSyntax Syntax
        {
            get { return operatorOverload.Syntax; }
            set { operatorOverload.Syntax = value; }
        }

        internal ClassOperatorOverloadWithCodeAnalysis InternalOperatorOverload
        {
            get { return operatorOverload; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitOperatorOverloadWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
