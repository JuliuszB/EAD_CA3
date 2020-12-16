using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorCA;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /*This test is devised to check if the two strings, category and newsType change 
            from their default to the passed values in the changeCategory() method in order to update the page content to Sports news*/
        public void changeCategoryStringToSportTest()
        {
            
            BlazorCA.Pages.NewsArticles ArticlePage = new BlazorCA.Pages.NewsArticles();
            string categorybefore = ArticlePage.Category;
            string newsTypeBefore = ArticlePage.NewsType;
            ArticlePage.changeCategory("category=sport&", " - Sport");
            string categoryAfter = ArticlePage.Category;
            string newsTypeAfter = ArticlePage.NewsType;
            Assert.AreEqual("",categorybefore);
            Assert.AreEqual("category=sport&",categoryAfter );

            Assert.AreEqual(" - Top Headlines",newsTypeBefore );
            Assert.AreEqual(" - Sport",newsTypeAfter );
        }

        [TestMethod]
        /*This test is devised to check if the two strings, category and newsType change 
            from their default to the passed values in the changeCategory() method in order to update the page content to Health news*/
        public void changeCategoryStringToHealthTest()
        {

            BlazorCA.Pages.NewsArticles ArticlePage = new BlazorCA.Pages.NewsArticles();
            string categorybefore = ArticlePage.Category;
            string newsTypeBefore = ArticlePage.NewsType;
            ArticlePage.changeCategory("category=health&", " - Health");
            string categoryAfter = ArticlePage.Category;
            string newsTypeAfter = ArticlePage.NewsType;
            Assert.AreEqual("",categorybefore);
            Assert.AreEqual("category=health&",categoryAfter);

            Assert.AreEqual(" - Top Headlines",newsTypeBefore);
            Assert.AreEqual(" - Health",newsTypeAfter );
        }

        [TestMethod]
        /*This test is devised to check if the two strings, country and newsFromCountry change 
            from their default to the passed values in the changeCountryAll() method in order to update the page content to News from the US*/
        public void changeCountryAllToUS()
        {

            BlazorCA.Pages.NewsArticles ArticlePage = new BlazorCA.Pages.NewsArticles();
            string countrybefore = ArticlePage.Country;
            string newsFromCountryBefore = ArticlePage.NewsFromCountry;
            ArticlePage.changeCountryAll("us", "United States");
            string countryAfter = ArticlePage.Country;
            string newsFromCountryAfter = ArticlePage.NewsFromCountry;
            Assert.AreEqual("ie",countrybefore );
            Assert.AreEqual("us", countryAfter);
            Assert.AreEqual("Ireland",newsFromCountryBefore);
            Assert.AreEqual("United States",newsFromCountryAfter);
        }

        [TestMethod]
        /*This test is devised to check if the two strings, country and newsFromCountry change 
            from their default to the passed values in the changeCountryAll() method in order to update the page content to News from Canada*/
        public void changeCountryAllToCanada()
        {

            BlazorCA.Pages.NewsArticles ArticlePage = new BlazorCA.Pages.NewsArticles();
            string countrybefore = ArticlePage.Country;
            string newsFromCountryBefore = ArticlePage.NewsFromCountry;
            ArticlePage.changeCountryAll("ca", "Canada");
            string countryAfter = ArticlePage.Country;
            string newsFromCountryAfter = ArticlePage.NewsFromCountry;
            Assert.AreEqual("ie",countrybefore);
            Assert.AreEqual("ca",countryAfter);
            Assert.AreEqual("Ireland",newsFromCountryBefore);
            Assert.AreEqual("Canada",newsFromCountryAfter );
        }
    }
}
