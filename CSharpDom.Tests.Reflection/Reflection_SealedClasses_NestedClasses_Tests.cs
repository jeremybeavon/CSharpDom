using CSharpDom.TestTarget.SealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithBaseClassUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithInternalNestedClassUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateNestedClassUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedNestedClassUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalNestedClassUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithPublicNestedClassUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicNestedClass));
        }
    }
}
