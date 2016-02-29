using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class OperatorOverloadWithMonoCecil :
        AbstractOperatorOverload<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            OperatorParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>//,
        //IVisitable<IReflectionVisitor>
    {
        private static readonly IDictionary<string, OperatorOverloadType> operatorTypes =
            new Dictionary<string, OperatorOverloadType>()
            {
                { "op_BitwiseAnd", OperatorOverloadType.And },
                { "op_OnesComplement", OperatorOverloadType.BitwiseNot },
                { "op_Decrement", OperatorOverloadType.Decrement },
                { "op_Division", OperatorOverloadType.Divide },
                { "op_Equality", OperatorOverloadType.Equal },
                { "op_ExclusiveOr", OperatorOverloadType.ExclusiveOr },
                { "op_False", OperatorOverloadType.False },
                { "op_GreaterThan", OperatorOverloadType.GreaterThan },
                { "op_GreaterThanOrEqual", OperatorOverloadType.GreaterThanOrEqual },
                { "op_Increment", OperatorOverloadType.Increment },
                { "op_LeftShift", OperatorOverloadType.LeftShift },
                { "op_LessThan", OperatorOverloadType.LessThan },
                { "op_LessThanOrEqual", OperatorOverloadType.LessThanOrEqual },
                { "op_LogicalNot", OperatorOverloadType.LogicalNot },
                { "op_Subtraction", OperatorOverloadType.Minus },
                { "op_UnaryNegation", OperatorOverloadType.Minus },
                { "op_Modulus", OperatorOverloadType.Modulo },
                { "op_Multiply", OperatorOverloadType.Multiply },
                { "op_Inequality", OperatorOverloadType.NotEqual },
                { "op_BitwiseOr", OperatorOverloadType.Or },
                { "op_Addition", OperatorOverloadType.Plus },
                { "op_UnaryPlus", OperatorOverloadType.Plus },
                { "op_RightShift", OperatorOverloadType.RightShift },
                { "op_True", OperatorOverloadType.True }
            };
        private readonly ITypeWithMonoCecil declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Parameters<OperatorParameterWithMonoCecil>> parameters;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> body;

        internal OperatorOverloadWithMonoCecil(ITypeWithMonoCecil declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType; 
            this.method = method;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, method.ReturnType);
            parameters = new Lazy<Parameters<OperatorParameterWithMonoCecil>>(
                () => new Parameters<OperatorParameterWithMonoCecil>(assembly, method, parameter => new OperatorParameterWithMonoCecil(parameter)));
            body = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorTypes[method.Name]; }
        }

        public override IReadOnlyList<OperatorParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitOperatorOverloadWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
