using CSharpDom.TestTarget.Structs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedAbstractClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithPublicNestedAbstractClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicNestedAbstractClass));
        }
    }
}
