using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassConstructorWithCodeAnalysis :
        AbstractClassConstructor<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition
    {
        private readonly ConstructorWithCodeAnalysis constructor;

        internal ClassConstructorWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition constructor)
        {
            this.constructor = new ConstructorWithCodeAnalysis(declaringType, constructor);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constructor.Attributes; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return constructor.Body; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return constructor.MethodDefinition; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return constructor.DeclaringType; }
        }

        public override IReadOnlyList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return constructor.Parameters; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return constructor.MethodDefinition.ClassVisibility(); }
        }
    }
}
