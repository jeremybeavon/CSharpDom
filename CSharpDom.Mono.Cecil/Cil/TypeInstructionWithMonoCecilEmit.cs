using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class TypeInstructionWithMonoCecilEmit : AbstractTypeInstruction<Type>, IILInstructionWithMonoCecilEmit
    {
        private static readonly IDictionary<OpCode, TypeInstructionType> instructionTypes =
            new Dictionary<OpCode, TypeInstructionType>()
            {
                { OpCodes.Box, TypeInstructionType.Box },
                { OpCodes.Castclass, TypeInstructionType.Cast },
                { OpCodes.Constrained, TypeInstructionType.Constrained },
                { OpCodes.Cpobj, TypeInstructionType.CopyObject },
                { OpCodes.Initobj, TypeInstructionType.InitializeObject },
                { OpCodes.Isinst, TypeInstructionType.IsInstanceOfClass },
                { OpCodes.Refanyval, TypeInstructionType.LoadAddress },
                { OpCodes.Ldelem, TypeInstructionType.LoadArrayElement },
                { OpCodes.Ldelema, TypeInstructionType.LoadArrayElementAddress },
                { OpCodes.Ldobj, TypeInstructionType.LoadObject },
                { OpCodes.Mkrefany, TypeInstructionType.LoadTypeReference },
                { OpCodes.Newarr, TypeInstructionType.NewArray },
                { OpCodes.Sizeof, TypeInstructionType.SizeOf },
                { OpCodes.Stelem, TypeInstructionType.StoreArrayElement },
                { OpCodes.Stobj, TypeInstructionType.StoreObject },
                { OpCodes.Unbox, TypeInstructionType.Unbox },
                { OpCodes.Unbox_Any, TypeInstructionType.UnboxAny }
            };


        private readonly OpCode opCode;
        private readonly TypeInstructionType instructionType;
        private readonly int token;
        private readonly Type type;

        public TypeInstructionWithMonoCecilEmit(OpCode opCode, int token, Type type)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.token = token;
            this.type = type;
        }

        public override TypeInstructionType InstructionType
        {
            get { return instructionType; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override int Token
        {
            get { return token; }
        }

        public override Type Type
        {
            get { return type; }
        }
    }
}
