using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedAbstractClass));
        }
    }
}
