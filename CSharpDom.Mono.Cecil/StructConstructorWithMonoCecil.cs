using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructConstructorWithMonoCecil :
        AbstractStructConstructor<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ConstructorParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>,
        IHasConstructorInfo
    {
        private readonly ConstructorWithMonoCecil constructor;

        internal StructConstructorWithMonoCecil(ITypeWithMonoCecil declaringType, ConstructorInfo constructor)
        {
            this.constructor = new ConstructorWithMonoCecil(declaringType, constructor);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return constructor.Attributes; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return constructor.Body; }
        }

        public ConstructorInfo ConstructorInfo
        {
            get { return constructor.ConstructorInfo; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return constructor.DeclaringType; }
        }

        public override IReadOnlyList<ConstructorParameterWithMonoCecil> Parameters
        {
            get { return constructor.Parameters; }
        }
        
        public override StructMemberVisibilityModifier Visibility
        {
            get { return constructor.ConstructorInfo.StructVisibility(); }
        }
    }
}
