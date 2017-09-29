using CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedClass));
        }
    }
}
