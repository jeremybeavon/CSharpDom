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
            TestSealedClass(typeof(SealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWith1GenericParameterUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestSealedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWith2GenericParametersUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestSealedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithBaseClassUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalSealedClassUsingMonoCecil()
        {
            TestSealedClass(typeof(InternalSealedClass));
        }

        [TestMethod]
        public void TestPublicSealedClassUsingMonoCecil()
        {
            TestSealedClass(typeof(PublicSealedClass));
        }
    }
}
