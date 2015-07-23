using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructBody : CodeGenerationNode
    {
        public StructBody()
        {
            Fields = new CodeGenerationCollection<StructFieldDeclaration>();
            Events = new CodeGenerationCollection<StructEvent>();
            Properties = new CodeGenerationCollection<StructProperty>();
            Indexers = new CodeGenerationCollection<StructIndexer>();
            Methods = new CodeGenerationCollection<StructMethod>();
            UnaryOperators = new CodeGenerationCollection<UnaryOperator>();
            BinaryOperators = new CodeGenerationCollection<BinaryOperator>();
            ConversionOperators = new CodeGenerationCollection<ConversionOperator>();
            NestedClasses = new CodeGenerationCollection<StructNestedClass>();
            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>();
            NestedEnums = new CodeGenerationCollection<StructNestedEnum>();
            NestedInterfaces = new CodeGenerationCollection<StructNestedInterface>();
            NestedStructs = new CodeGenerationCollection<StructNestedStruct>();
        }

        public CodeGenerationCollection<StructFieldDeclaration> Fields { get; set; }

        public CodeGenerationCollection<StructEvent> Events { get; set; }

        public CodeGenerationCollection<StructProperty> Properties { get; set; }

        public CodeGenerationCollection<StructIndexer> Indexers { get; set; }

        public CodeGenerationCollection<StructMethod> Methods { get; set; }

        public CodeGenerationCollection<UnaryOperator> UnaryOperators { get; set; }

        public CodeGenerationCollection<BinaryOperator> BinaryOperators { get; set; }

        public CodeGenerationCollection<ConversionOperator> ConversionOperators { get; set; }

        public CodeGenerationCollection<StructNestedClass> NestedClasses { get; set; }

        public CodeGenerationCollection<StructNestedDelegate> NestedDelegates { get; set; }

        public CodeGenerationCollection<StructNestedEnum> NestedEnums { get; set; }

        public CodeGenerationCollection<StructNestedInterface> NestedInterfaces { get; set; }

        public CodeGenerationCollection<StructNestedStruct> NestedStructs { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Fields.AcceptIfNotNull(visitor);
            Events.AcceptIfNotNull(visitor);
            Properties.AcceptIfNotNull(visitor);
            Indexers.AcceptIfNotNull(visitor);
            Methods.AcceptIfNotNull(visitor);
            UnaryOperators.AcceptIfNotNull(visitor);
            BinaryOperators.AcceptIfNotNull(visitor);
            ConversionOperators.AcceptIfNotNull(visitor);
            NestedClasses.AcceptIfNotNull(visitor);
            NestedDelegates.AcceptIfNotNull(visitor);
            NestedEnums.AcceptIfNotNull(visitor);
            NestedInterfaces.AcceptIfNotNull(visitor);
            NestedStructs.AcceptIfNotNull(visitor);
        }
    }
}
