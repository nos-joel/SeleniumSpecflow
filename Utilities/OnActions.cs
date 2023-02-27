using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


/// <summary>
/// OnActions class. It contains the defined list of available actions to perform over an element
/// </summary>
public class OnActions
{
    private IWebElement element;

    public IWebElement Element
    {
        get { return element; }
        set { element = value; }
    }

    AssertOptions assertoptions = new AssertOptions();

    /// <summary>
    /// Perform a Click over an object
    /// </summary>
    public void Click()
    {
        element.Click();
    }

    /// <summary>
    /// Perform SendKeys
    /// </summary>
    /// <param name="input_string"></param>
    public void Input(string input_string)
    {
        element.Clear(); //Clear input first
        element.SendKeys(input_string);
    }

    /// <summary>
    /// Define that an Assert with be performed on a object
    /// </summary>
    /// <param name="object's attribute_name"></param>
    /// <returns>AssertOptions</returns>
    public AssertOptions AssertThat(string attribute_name)
    {

        string current_value = element.GetAttribute(attribute_name);

        assertoptions.current_value = current_value;

        return assertoptions;
    }

    /// <summary>
    /// Select dropdown by value
    /// </summary>
    /// <param name="value"></param>
    public void SelectByValue(string value)
    {
        SelectElement select = new SelectElement(element);
        select.SelectByValue(value);
    }

    /// <summary>
    /// Select dropdown by index
    /// </summary>
    /// <param name="value"></param>
    public void SelectByIndex(int value)
    {
        SelectElement select = new SelectElement(element);
        select.SelectByIndex(value);
    }

    /// <summary>
    /// Select dropdown by text
    /// </summary>
    /// <param name="value"></param>
    public void SelectByText(string value)
    {
        SelectElement select = new SelectElement(element);
        select.SelectByText(value);
    }
}