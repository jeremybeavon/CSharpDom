using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassDestructorWithCodeAnalysis :
        EditableDestructor<AttributeGroupWithCodeAnalysis, IClass, MethodBodyWithCodeAnalysis>,
        IHasSyntax<DestructorDeclarationSyntax>,
        IHasNode<DestructorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly DestructorWithCodeAnalysis destructor;

        public ClassDestructorWithCodeAnalysis(
            string name,
            MethodBodyWithCodeAnalysis body)
            : this()
        {
            Syntax = SyntaxFactory.DestructorDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList),
                SyntaxFactory.Identifier(name),
                SyntaxFactory.ParameterList(),
                body.Syntax);
        }

        internal ClassDestructorWithCodeAnalysis()
        {
            destructor = new DestructorWithCodeAnalysis();
        }

        public DestructorWithCodeAnalysis Destructor
        {
            get { return destructor; }
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return destructor.Attributes; }
            set { destructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return destructor.Body; }
            set { destructor.Body = value; }
        }

        public override IClass DeclaringType
        {
            get { return destructor.Node.GetParentNode<IClass>(); }
            set { throw new NotSupportedException(); }
        }
        
        public DestructorDeclarationSyntax Syntax
        {
            get { return destructor.Syntax; }
            set { destructor.Syntax = value; }
        }

        INode<DestructorDeclarationSyntax> IHasNode<DestructorDeclarationSyntax>.Node
        {
            get { return destructor.Node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
