using CSharpDom.TestTarget.Classes.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithBaseClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestClassWithPublicNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicNestedClass));
        }
    }
}
