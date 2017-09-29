using CSharpDom.TestTarget.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(InternalStruct));
        }

        [TestMethod]
        public void TestPublicStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(PublicStruct));
        }
    }
}
