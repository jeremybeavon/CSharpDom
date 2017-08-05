using CSharpDom.TestTarget.Structs.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithInternalNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithPrivateNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithPublicNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPublicNestedStruct));
        }
    }
}
