using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium
{
	public class CategoryPage : AbstractPage
	{

		public CategoryPage (IWebDriver driver) : base(driver)
		{

		}

		public String  sortBy(String sortByText){
			IWebElement sortByElement = driver.FindElement( By.Id("sortBy") );
			SelectElement selector = new SelectElement(sortByElement);
			selector.SelectByText(sortByText);

			var selectedItemText = (string)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].options[arguments[0].selectedIndex].text;", sortByElement);

			return selectedItemText;
		}
	}
}

