using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class Attributes
    {
        public Attributes(AssemblyWithCodeAnalysis assembly, ICustomAttributeProvider member, params Type[] excludedTypes)
        {
            string[] excludedTypeReferences = excludedTypes.Select(type => type.FullName).ToArray();
            AttributesWithCodeAnalysis = member.CustomAttributes
                .Where(attribute => !excludedTypeReferences.Contains(attribute.Constructor.DeclaringType.FullName))
                .Select(attribute => new AttributeGroupWithCodeAnalysis(assembly, attribute))
                .ToList();
        }
        
        public IReadOnlyCollection<AttributeGroupWithCodeAnalysis> AttributesWithCodeAnalysis { get; private set; }
    }
}
