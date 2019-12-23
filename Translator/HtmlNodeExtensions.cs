using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public static class HtmlNodeExtensions
    {
        //tagNames
        // "input" "select" "textarea" "div" "span"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="tagName"></param>
        /// <param name="atribute"></param>
        /// <param name="atributeValue"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByAtribute(this HtmlNode parent, string tagName, string atribute, string atributeValue)
        {
            //return parent.SelectNodes("//" + tagName + "[@" + atribute + "='" + atributeValue + "']");
            //return parent.Descendants(tagName).Where(node => node.GetAttributeValue(atribute, null).Equals(atributeValue, StringComparison.InvariantCultureIgnoreCase));
            return parent.Descendants(tagName).Where(n => n.Attributes[atribute] != null && n.Attributes[atribute].Value == atributeValue);
        }
        /// <summary>
        /// Any nodes by atribute:
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="atribute"></param>
        /// <param name="atributeValue"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByAtribute(this HtmlNode parent, string atribute, string atributeValue)
        {
            //return parent.SelectNodes("//*[@" + atribute + "='" + atributeValue + "']");
            //return parent.Descendants().Where(node => node.GetAttributeValue(atribute, null).Equals(atributeValue, StringComparison.InvariantCultureIgnoreCase));
            return parent.Descendants().Where(n => n.Attributes[atribute] != null && n.Attributes[atribute].Value == atributeValue);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="tagName"></param>
        /// <param name="atribute"></param>
        /// <param name="atributeValue"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByAtribute(this HtmlDocument doc, string tagName, string atribute, string atributeValue)
        {
            //return parent.SelectNodes("//" + tagName + "[@" + atribute + "='" + atributeValue + "']");
            //return doc.DocumentNode.Descendants(tagName).Where(node => node.GetAttributeValue(atribute, null).Equals(atributeValue, StringComparison.InvariantCultureIgnoreCase));
            return doc.DocumentNode.Descendants(tagName).Where(n => n.Attributes[atribute] != null && n.Attributes[atribute].Value == atributeValue);
        }
        /// <summary>
        /// Any nodes by atribute:
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="atribute"></param>
        /// <param name="atributeValue"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByAtribute(this HtmlDocument doc, string atribute, string atributeValue)
        {
            //return parent.SelectNodes("//*[@" + atribute + "='" + atributeValue + "']");
            //return doc.DocumentNode.Descendants().Where(node => node.GetAttributeValue(atribute, null).Equals(atributeValue, StringComparison.InvariantCultureIgnoreCase));
            return doc.DocumentNode.Descendants().Where(n => n.Attributes[atribute] != null && n.Attributes[atribute].Value == atributeValue);
        }

        /// <summary>
        /// Any nodes by id:
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsById(this HtmlNode parent, string id)
        {           
            //return parent.SelectNodes("//*[@id='" + id + "']");
            return parent.Descendants().Where(node => node.Id != null && node.Id == id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="tagName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsById(this HtmlNode parent, string tagName, string id)
        {
            //return parent.SelectNodes("//" + tagName + "[@id='" + id + "']");
            return parent.Descendants(tagName).Where(node => node.Id != null && node.Id == id);
        }
        /// <summary>
        /// Any nodes by id:
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsById(this HtmlDocument doc, string id)
        {
            //return parent.SelectNodes("//*[@id='" + id + "']");
            return doc.DocumentNode.Descendants().Where(node => node.Id != null && node.Id == id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="id"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsById(this HtmlDocument doc, string tagName, string id)
        {
            //return parent.SelectNodes("//" + tagName + "[@id='" + id + "']");
            return doc.DocumentNode.Descendants(tagName).Where(node => node.Id != null && node.Id == id);
        }

        /// <summary>
        /// If you're looking for the tag by its name property (such as someForm for <form name="someForm"></form>)
        /// document.DocumentNode.Descendants().Where(node => node.Name == "formName");
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlNode parent, string name)
        {
            return parent.Descendants().Where(node => node.Name != null && node.Name == name);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="tagName"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlNode parent, string tagName, string name)
        {
            return parent.Descendants(tagName).Where(node => node.Name != null && node.Name == name);
        }
        /// <summary>
        /// If you're looking for the tag by its name property (such as someForm for <form name="someForm"></form>)
        /// document.DocumentNode.Descendants().Where(node => node.Name == "formName");
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlDocument doc, string name)
        {
            return doc.DocumentNode.Descendants().Where(node => node.Name != null && node.Name == name);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="tagName"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlDocument doc, string tagName, string name)
        {
            return doc.DocumentNode.Descendants(tagName).Where(node => node.Name != null && node.Name == name);
        }

        /// <summary>
        /// Any nodes by type:
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByType(this HtmlNode parent, string type)
        {
            //return parent.SelectNodes("//*[@type='" + type + "']");
            return parent.Descendants().Where(n => n.Attributes["type"] != null && n.Attributes["type"].Value == type);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="type"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByType(this HtmlNode parent, string tagName, string type)
        {
            //return parent.SelectNodes("//" + tagName + "[@type='" + type + "']");
            return parent.Descendants(tagName).Where(n => n.Attributes["type"] != null && n.Attributes["type"].Value == type);
        }
        /// <summary>
        /// Any nodes by type:
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByType(this HtmlDocument doc, string type)
        {
            //return doc.DocumentNode.SelectNodes("//*[@type='" + type + "']");
            return doc.DocumentNode.Descendants().Where(n => n.Attributes["type"] != null && n.Attributes["type"].Value == type);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="type"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByType(this HtmlDocument doc, string tagName, string type)
        {
            //return doc.DocumentNode.SelectNodes("//" + tagName + "[@type='" + type + "']");
            return doc.DocumentNode.Descendants(tagName).Where(n => n.Attributes["type"] != null && n.Attributes["type"].Value == type);
        }

        /// <summary>
        /// Any nodes by type:
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="Class"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByClass(this HtmlNode parent, string Class)
        {
            return parent.SelectNodes("//*[@class='" + Class + "']");
            //return parent.Descendants().Where(n => n.Attributes["class"] != null && n.Attributes["class"].Value == Class);
            //return parent.SelectNodes("//*[contains(@class, '" + Class + "')]");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="Class"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByClass(this HtmlNode parent, string tagName, string Class)
        {
            return parent.SelectNodes("//" + tagName + "[@class='" + Class + "']");
            //return parent.Descendants(tagName).Where(n => n.Attributes["class"] != null && n.Attributes["class"].Value == Class);
            //return parent.SelectNodes("//" + tagName + "[contains(@class, '" + Class + "')]");
        }
        /// <summary>
        /// Any nodes by type:
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="Class"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByClass(this HtmlDocument doc, string Class)
        {
            return doc.DocumentNode.SelectNodes("//*[@class='" + Class + "']");
            //return doc.DocumentNode.Descendants().Where(n => n.Attributes["class"] != null && n.Attributes["class"].Value == Class);
            //return doc.DocumentNode.SelectNodes("//*[contains(@class, '" + Class + "')]");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="Class"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByClass(this HtmlDocument doc, string tagName, string Class)
        {
            return doc.DocumentNode.SelectNodes("//" + tagName + "[@class='" + Class + "']");
            //return doc.DocumentNode.Descendants(tagName).Where(n => n.Attributes["class"] != null && n.Attributes["class"].Value == Class);
            //return doc.DocumentNode.SelectNodes("//" + tagName + "[contains(@class, '" + Class + "')]");
        }

        /// <summary>
        /// If you're looking for the tag by its tagName (such as form for <form name="someForm"></form>)
        /// document.DocumentNode.Descendants("form");
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByTagName(this HtmlNode parent, string tagName)
        {
            return parent.Descendants(tagName);
        }
        /// <summary>
        /// If you're looking for the tag by its tagName (such as form for <form name="someForm"></form>)
        /// document.DocumentNode.Descendants("form");
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlNode> GetElementsByTagName(this HtmlDocument doc, string tagName)
        {
            return doc.DocumentNode.Descendants(tagName);
        }

        #region HtmlAgilityPack
        // GetElementbyId
        //HtmlNode specificNode = doc.GetElementbyId("history-input");
        //doc.DocumentNode.SelectSingleNode("//div[@id='uiDynamicText']")
        //HtmlAgilityPack.HtmlNode node = doc.GetElementbyId(id);

        //HtmlNodeCollection nodes = docNode.SelectNodes("//input"); //SelectNodes takes a XPath expression
        //foreach (HtmlNode node in nodes)
        //{
        //    String id = node.GetAttributeValue("id", null);      // Fetch id of HTML element
        //    String name = node.GetAttributeValue("name", null);  // Fetch parameter name (GET/POST)
        //    String type = node.GetAttributeValue("type", null);  // Fetch type of input element
        //                                                         // Do your processing now
        //}
        #endregion
        #region System.Windows.Forms
        //using System.Windows.Forms;
        //HtmlDocument doc = webBrowser1.Document;
        //HtmlElement Username = doc.GetElementById("user_name");
        //
        //IEnumerable<HtmlElement> ElementsByClass(HtmlDocument htmlDocument, string className)
        //{
        //    foreach (HtmlElement e in htmlDocument.All)
        //        if (e.GetAttribute("className") == className)
        //            yield return e;
        //}
        #endregion
        #region dynamic document 
        //dynamic document = (JSObject)webView.ExecuteJavascriptWithResult("document");
        //Получить все элементы класса 'test':
        //var testElements = document.getElementsByClassName('test');
        //var testDivs = Array.prototype.filter.call(testElements, function(testElement){
        //    return testElement.nodeName === 'DIV';
        //});
        //Получить все элементы, для которых заданы класс 'red' и класс 'test':
        //document.getElementsByClassName('red test');
        //Получить все элементы класса 'test', являющиеся дочерними для элемента с ID 'main':
        //document.getElementById('main').getElementsByClassName('test');
        #endregion

    }
}
