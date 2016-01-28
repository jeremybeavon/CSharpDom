using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyBinaryOperator :
        AbstractOperatorOverload<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyTypeReference,
            ReadOnlyOperatorParameter,
            ReadOnlyMethodBody>
    {
        private static readonly IDictionary<BinaryOperatorType, OperatorOverloadType> operatorTypes =
            new Dictionary<BinaryOperatorType, OperatorOverloadType>()
            {
                { BinaryOperatorType.And, OperatorOverloadType.And },
                { BinaryOperatorType.Divide, OperatorOverloadType.Divide },
                { BinaryOperatorType.Equal, OperatorOverloadType.Equal },
                { BinaryOperatorType.ExclusiveOr, OperatorOverloadType.ExclusiveOr },
                { BinaryOperatorType.GreaterThan, OperatorOverloadType.GreaterThan },
                { BinaryOperatorType.GreaterThanOrEqual, OperatorOverloadType.GreaterThanOrEqual },
                { BinaryOperatorType.LeftShift, OperatorOverloadType.LeftShift },
                { BinaryOperatorType.LessThan, OperatorOverloadType.LessThan },
                { BinaryOperatorType.LessThanOrEqual, OperatorOverloadType.LessThanOrEqual },
                { BinaryOperatorType.Minus, OperatorOverloadType.Minus },
                { BinaryOperatorType.Modulo, OperatorOverloadType.Modulo },
                { BinaryOperatorType.Multiply, OperatorOverloadType.Multiply },
                { BinaryOperatorType.NotEqual, OperatorOverloadType.NotEqual },
                { BinaryOperatorType.Or, OperatorOverloadType.Or },
                { BinaryOperatorType.Plus, OperatorOverloadType.Plus },
                { BinaryOperatorType.RightShift, OperatorOverloadType.RightShift }
            };

        private readonly BinaryOperator binaryOperator;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyOperatorParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyBinaryOperator(BinaryOperator binaryOperator)
        {
            this.binaryOperator = binaryOperator;
            body = new ReadOnlyMethodBody(binaryOperator.Body);
            parameters = new ReadOnlyOperatorParameter[]
            {
                new ReadOnlyOperatorParameter(binaryOperator.Parameter1Name, binaryOperator.Parameter1Type),
                new ReadOnlyOperatorParameter(binaryOperator.Parameter2Name, binaryOperator.Parameter2Type)
            };
            returnType = new ReadOnlyTypeReference(binaryOperator.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get { return body; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override OperatorOverloadType OperatorType
        {
            get { return operatorTypes[binaryOperator.OperatorType]; }
        }

        public override IReadOnlyList<ReadOnlyOperatorParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }
    }
}
