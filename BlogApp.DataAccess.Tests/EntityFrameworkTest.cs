using BlogApp.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogApp.DataAccess.Tests
{
    [TestClass]
    public class EntityFrameworkTest

    {
        [TestMethod]
        public void Get_all_returns_categories()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();
            var result = categoryDal.GetList();
            Assert.AreEqual(3, result.Count);

        }

        [TestMethod]
        public void Get_all_with_paramaters_filtered_categories()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();
            var result = categoryDal.GetList(p => p.CategoryName.Contains("de"));
            Assert.AreEqual(1,result.Count);

        }
 
    }
}
