﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Common.Partial;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructNestedStructCollection :
        AbstractStructNestedStructCollection<ReadOnlyStructNestedStruct, IStructNestedPartialStruct>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructNestedStruct> structs;

        public ReadOnlyStructNestedStructCollection(StructBody structBody)
        {
            structs = structBody.NestedStructs.ToArray(@struct => new ReadOnlyStructNestedStruct(@struct));
        }

        public override IReadOnlyCollection<IStructNestedPartialStruct> PartialStructs
        {
            get { return new IStructNestedPartialStruct[0]; }
        }

        protected override IReadOnlyCollection<ReadOnlyStructNestedStruct> Structs
        {
            get { return structs; }
        }
    }
}
