using CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
