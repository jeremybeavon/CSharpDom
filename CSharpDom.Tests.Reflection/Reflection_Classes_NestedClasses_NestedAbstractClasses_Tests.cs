using CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedAbstractClass));
        }
    }
}
