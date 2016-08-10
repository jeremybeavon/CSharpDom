using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithProtectedNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicNestedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicNestedClass));
        }
    }
}
