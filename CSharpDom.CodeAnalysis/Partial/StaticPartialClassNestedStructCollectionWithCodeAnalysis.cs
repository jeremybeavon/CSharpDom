using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            StaticPartialClassNestedStructWithCodeAnalysis,
            StaticPartialClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            StaticClassNestedStructWithCodeAnalysis,
            StaticPartialClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            StaticClassNestedPartialStructWithCodeAnalysis,
            StaticPartialClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal StaticPartialClassNestedStructCollectionWithCodeAnalysis(
            StaticClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<StaticClassNestedStructWithCodeAnalysis, StaticPartialClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new StaticPartialClassNestedStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<StaticClassNestedPartialStructWithCodeAnalysis, StaticPartialClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new StaticPartialClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<StaticPartialClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<StaticPartialClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
