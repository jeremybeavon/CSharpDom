using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassDestructorWithCodeAnalysis :
        EditableDestructor<AttributeGroupWithCodeAnalysis, IAbstractPartialTypeWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<DestructorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassDestructorWithCodeAnalysis destructor;

        public AbstractPartialClassDestructorWithCodeAnalysis(
            string name,
            MethodBodyWithCodeAnalysis body)
            : this(new ClassDestructorWithCodeAnalysis(name, body))
        {
        }
        
        internal AbstractPartialClassDestructorWithCodeAnalysis(ClassDestructorWithCodeAnalysis destructor)
        {
            this.destructor = destructor;
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

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return destructor.Destructor.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }
        
        public DestructorDeclarationSyntax Syntax
        {
            get { return destructor.Syntax; }
            set { destructor.Syntax = value; }
        }
        
        internal ClassDestructorWithCodeAnalysis InternalDestructor
        {
            get { return destructor; }
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
