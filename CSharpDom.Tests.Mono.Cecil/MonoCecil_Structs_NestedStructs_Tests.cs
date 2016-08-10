using CSharpDom.TestTarget.Structs.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestStructWithPublicNestedStructUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicNestedStruct));
        }
    }
}
