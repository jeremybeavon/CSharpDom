using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicNestedClassUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedClass));
        }
    }
}
