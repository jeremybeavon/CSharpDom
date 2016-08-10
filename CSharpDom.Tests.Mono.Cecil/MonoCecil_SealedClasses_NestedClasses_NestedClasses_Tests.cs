using CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicNestedClass));
        }
    }
}
