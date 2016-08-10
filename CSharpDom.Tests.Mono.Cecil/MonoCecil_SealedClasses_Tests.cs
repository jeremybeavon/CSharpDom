using CSharpDom.TestTarget.SealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWith1GenericParameterUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestSealedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWith2GenericParametersUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestSealedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithBaseClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalSealedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(InternalSealedClass));
        }

        [TestMethod]
        public void TestPublicSealedClassUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(PublicSealedClass));
        }
    }
}
