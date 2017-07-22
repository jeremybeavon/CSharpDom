using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassConstructorWithCodeAnalysis :
        EditableClassConstructor<
            AttributeGroupWithCodeAnalysis,
            IPartialClassTypeWithCodeAnalysis,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<ConstructorDeclarationSyntax>
    {
        private readonly ClassConstructorWithCodeAnalysis constructor;

        public PartialClassConstructorWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name,
            IEnumerable<ConstructorParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis body)
            : this(new ClassConstructorWithCodeAnalysis(visibility, name, parameters, body))
        {
        }

        internal PartialClassConstructorWithCodeAnalysis(ClassConstructorWithCodeAnalysis constructor)
        {
            this.constructor = constructor;
            constructor.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        internal ClassConstructorWithCodeAnalysis Constructor
        {
            get { return constructor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constructor.Attributes; }
            set { constructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return constructor.Body; }
            set { constructor.Body = value; }
        }
        
        public override IPartialClassTypeWithCodeAnalysis DeclaringType
        {
            get { return constructor.Constructor.Node.GetParentNode<IPartialClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
            set { constructor.Parameters = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                ConstructorDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public ConstructorDeclarationSyntax Syntax
        {
            get { return constructor.Syntax; }
            set { constructor.Syntax = value; }
        }
    }
}
