using CSharpDom.TestTarget.Structs.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedInterfaces_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedInterfaceWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestStructWithPublicNestedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicNestedInterface));
        }
    }
}
