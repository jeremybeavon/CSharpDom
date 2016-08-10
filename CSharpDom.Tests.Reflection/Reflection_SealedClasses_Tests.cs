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
            TestSealedClassAsync(typeof(SealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWith1GenericParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWith2GenericParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithBaseClassUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalSealedClassUsingReflection()
        {
            TestSealedClassAsync(typeof(InternalSealedClass));
        }

        [TestMethod]
        public void TestPublicSealedClassUsingReflection()
        {
            TestSealedClassAsync(typeof(PublicSealedClass));
        }
    }
}
