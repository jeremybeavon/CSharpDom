using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_NestedInterfaces_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedInterface));
        }
    }
}
