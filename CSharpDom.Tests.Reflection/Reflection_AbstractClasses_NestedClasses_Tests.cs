using CSharpDom.TestTarget.AbstractClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithBaseClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicNestedClassUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedClass));
        }
    }
}
