using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedStaticClass));
        }
    }
}
