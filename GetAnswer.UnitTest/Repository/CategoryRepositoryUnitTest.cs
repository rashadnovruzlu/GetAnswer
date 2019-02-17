using System;
using GetAnswer.Helpers;
using GetAnswer.Model;
using GetAnswer.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetAnswer.UnitTest
{
    [TestClass]
    public class CategoryRepositoryUnitTest
    {
        IGetAnswerResolver _getAnswerResolver;

        ICategoryRepository _repository;

        [TestInitialize]
        public void Init()
        {
            _getAnswerResolver = new GetAnswerResolver();

            _repository = _getAnswerResolver.Create<ICategoryRepository>();

        }

        [TestMethod]
        public void Create()
        {
            Category category = new Category
            {
                Name = "IT",
                Status = true
            };

            _repository.Add(category);

            Assert.IsTrue(category.Id != 0);

        }
    }
}
