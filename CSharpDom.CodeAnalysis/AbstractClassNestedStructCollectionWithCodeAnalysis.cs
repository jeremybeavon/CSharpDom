using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<
            AbstractClassNestedStructWithCodeAnalysis,
            AbstractClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassNestedStructWithCodeAnalysis,
            AbstractClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            ClassNestedPartialStructWithCodeAnalysis,
            AbstractClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal AbstractClassNestedStructCollectionWithCodeAnalysis(
            ClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<ClassNestedStructWithCodeAnalysis, AbstractClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new AbstractClassNestedStructWithCodeAnalysis(parent),
                child => child.InternalStruct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<ClassNestedPartialStructWithCodeAnalysis, AbstractClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new AbstractClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<AbstractClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<AbstractClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
