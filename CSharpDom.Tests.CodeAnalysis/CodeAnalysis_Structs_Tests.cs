using CSharpDom.TestTarget.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(InternalStruct));
        }

        [TestMethod]
        public async Task TestPublicStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(PublicStruct));
        }
    }
}
