using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedClass));
        }
    }
}
