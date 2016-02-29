using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassConstructorWithMonoCecil :
        AbstractClassConstructor<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ConstructorParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
    {
        private readonly ConstructorWithMonoCecil constructor;

        internal ClassConstructorWithMonoCecil(ITypeWithMonoCecil declaringType, MethodDefinition constructor)
        {
            this.constructor = new ConstructorWithMonoCecil(declaringType, constructor);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return constructor.Attributes; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return constructor.Body; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return constructor.MethodDefinition; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return constructor.DeclaringType; }
        }

        public override IReadOnlyList<ConstructorParameterWithMonoCecil> Parameters
        {
            get { return constructor.Parameters; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return constructor.MethodDefinition.ClassVisibility(); }
        }
    }
}
