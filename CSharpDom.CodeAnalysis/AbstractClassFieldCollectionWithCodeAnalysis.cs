using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassFieldCollectionWithCodeAnalysis :
        EditableClassFieldCollection<AbstractClassFieldWithCodeAnalysis, AbstractClassConstantWithCodeAnalysis>
    {
        private readonly WrappedCollection<ClassConstantWithCodeAnalysis, AbstractClassConstantWithCodeAnalysis> constants;
        private readonly WrappedCollection<ClassFieldWithCodeAnalysis, AbstractClassFieldWithCodeAnalysis> fields;

        public AbstractClassFieldCollectionWithCodeAnalysis(ClassFieldCollectionWithCodeAnalysis fieldCollection)
        {
            constants = new WrappedCollection<ClassConstantWithCodeAnalysis, AbstractClassConstantWithCodeAnalysis>(
                fieldCollection.Constants,
                parent => new AbstractClassConstantWithCodeAnalysis(parent),
                child => child.Constant,
                value => fieldCollection.Constants = value);
            fields = new WrappedCollection<ClassFieldWithCodeAnalysis, AbstractClassFieldWithCodeAnalysis>(
                fieldCollection.Fields,
                parent => new AbstractClassFieldWithCodeAnalysis(parent),
                child => child.InternalField,
                value => fieldCollection.Fields = value);
        }

        public override ICollection<AbstractClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { constants.Replace(value); }
        }

        public override ICollection<AbstractClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { fields.Replace(value); }
        }
    }
}
