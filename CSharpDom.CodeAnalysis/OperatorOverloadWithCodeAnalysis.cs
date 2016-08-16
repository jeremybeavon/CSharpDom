using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class OperatorOverloadWithCodeAnalysis :
        AbstractOperatorOverload<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>//,
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
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis returnType;
        private readonly Lazy<Parameters<OperatorParameterWithCodeAnalysis>> parameters;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        internal OperatorOverloadWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType; 
            this.method = method;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            returnType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, method.ReturnType, method);
            parameters = new Lazy<Parameters<OperatorParameterWithCodeAnalysis>>(
                () => new Parameters<OperatorParameterWithCodeAnalysis>(assembly, method, parameter => new OperatorParameterWithCodeAnalysis(parameter)));
            body = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(method));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorTypes[method.Name]; }
        }

        public override IReadOnlyList<OperatorParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
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
