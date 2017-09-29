using CSharpDom.TestTarget.Structs.NestedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedStruct));
        }
    }
}
