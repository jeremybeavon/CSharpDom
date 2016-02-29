using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class TypeInstructionWithMonoCecilCil : AbstractTypeInstruction<TypeDefinition>, IILInstructionWithMonoCecilCil
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
                { OpCodes.Ldelem_Any, TypeInstructionType.LoadArrayElement },
                { OpCodes.Ldelema, TypeInstructionType.LoadArrayElementAddress },
                { OpCodes.Ldobj, TypeInstructionType.LoadObject },
                { OpCodes.Mkrefany, TypeInstructionType.LoadTypeReference },
                { OpCodes.Newarr, TypeInstructionType.NewArray },
                { OpCodes.Sizeof, TypeInstructionType.SizeOf },
                { OpCodes.Stelem_Any, TypeInstructionType.StoreArrayElement },
                { OpCodes.Stobj, TypeInstructionType.StoreObject },
                { OpCodes.Unbox, TypeInstructionType.Unbox },
                { OpCodes.Unbox_Any, TypeInstructionType.UnboxAny }
            };


        private readonly OpCode opCode;
        private readonly TypeInstructionType instructionType;
        private readonly int token;
        private readonly TypeDefinition type;

        public TypeInstructionWithMonoCecilCil(OpCode opCode, int token, TypeDefinition type)
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

        public override TypeDefinition Type
        {
            get { return type; }
        }
    }
}
