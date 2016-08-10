using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualMethod));
        }
    }
}
