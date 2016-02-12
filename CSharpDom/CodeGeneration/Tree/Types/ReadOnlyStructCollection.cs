using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructCollection :
        AbstractStructCollection<ReadOnlyStruct, PartialStructNotSupported>
    {
        private readonly IReadOnlyCollection<ReadOnlyStruct> structs;

        public ReadOnlyStructCollection(IEnumerable<Struct> structs)
        {
            this.structs = structs.ToArray(@struct => new ReadOnlyStruct(@struct));
        }

        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<ReadOnlyStruct> Structs
        {
            get { return structs; }
        }
    }
}
