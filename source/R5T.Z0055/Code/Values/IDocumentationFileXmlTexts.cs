using System;

using R5T.T0131;
using R5T.T0212;
using R5T.T0212.Extensions;


namespace R5T.Z0055
{
    [ValuesMarker]
    public partial interface IDocumentationFileXmlTexts : IValuesMarker
    {
        /// <summary>
        /// A good text with several inheritdoc elements that create an inheritance chain three levels deep.
        /// </summary>
        public IDocumentationFileXmlText R5T_T0211 => @"
<?xml version=""1.0""?>
<doc>
    <assembly>
        <name>R5T.T0211</name>
    </assembly>
    <members>
        <member name=""T:R5T.T0211.Documentation"">
            <summary>
            .NET documentation XML file strong types library.
            </summary>
        </member>
        <member name=""M:R5T.T0211.Extensions.XElementExtensions.ToCElement(System.Xml.Linq.XElement)"">
            Somemore extra text.
            <inheritdoc cref=""M:R5T.T0211.Extensions.IXElementOperator.ToCElement(System.Xml.Linq.XElement)""/>
        </member>
        <member name=""M:R5T.T0211.Extensions.IXElementOperator.ToCElement(System.Xml.Linq.XElement)"">
            <inheritdoc cref=""T:R5T.T0211.ICElement""/>
            Extra text content outside of an element.
        </member>
        <member name=""T:R5T.T0211.CElement"">
            <inheritdoc cref=""T:R5T.T0211.ICElement""/>
            <inheritdoc cref=""T:R5T.T0211.ICElement"" path=""/summary/para""/>
        </member>
        <member name=""T:R5T.T0211.ICElement"">
            <summary>
            Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
            <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
            </summary>
        </member>
    </members>
</doc>
".Trim().ToDocumentationFileXmlText();
    }
}
