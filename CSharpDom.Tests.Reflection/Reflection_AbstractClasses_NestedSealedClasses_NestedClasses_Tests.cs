using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithBaseClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
