using CSharpDom.TestTarget.SealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWith1GenericParameterUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWith2GenericParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithBaseClassUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalSealedClassUsingReflection()
        {
            TestSealedClass(typeof(InternalSealedClass));
        }

        [TestMethod]
        public void TestPublicSealedClassUsingReflection()
        {
            TestSealedClass(typeof(PublicSealedClass));
        }
    }
}
