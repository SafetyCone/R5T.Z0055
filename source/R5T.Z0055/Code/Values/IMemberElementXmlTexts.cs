using System;

using R5T.T0131;
using R5T.T0212;
using R5T.T0212.Extensions;


namespace R5T.Z0055
{
    /// <summary>
    /// Provides the XML-formatted texts of individual &lt;member&gt; elements in a .NET assembly XML documentation file.
    /// </summary>
    [ValuesMarker]
    public partial interface IMemberElementXmlTexts : IValuesMarker
    {
        private static Raw.IMemberElementXmlTexts Raw => Z0055.Raw.MemberElementXmlTexts.Instance;


        /// <summary>
        /// The formatting of the .NET XML documentation files for the .NET framework itself are subtly different than those produced by VS.
        /// Specifically, whereas VS uses 4-spaces (a 4-spaced tab) for indentation, the VS file uses two spaces (a 2-spaced tab) for indentation.
        /// </summary>
        public IMemberElementXmlText RawNetFrameworkFileFormatting =>
@"
    <member name=""M:Microsoft.CSharp.RuntimeBinder.Binder.Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags,System.Type,System.Type)"">
      <summary>Initializes a new CSharp convert binder.</summary>
      <param name=""flags"">The flags with which to initialize the binder.</param>
      <param name=""type"">The type to convert to.</param>
      <param name=""context"">The <see cref=""T:System.Type"" /> that indicates where this operation is used.</param>
      <returns>A new CSharp convert binder.</returns>
    </member>
"
// Do not trim.
.ToMemberElementXmlText();

        /// <summary>
        /// A member element with extra new lines that simulates how member elements are found in an XML documentation file.
        /// </summary>
        /// <remarks>
        /// In the .NET assembly XML documentation file, member elements are indented by several tabs.
        /// This causes trouble because it means that the text content of member elements is also indented by several tabs.
        /// This means that the actual text of a documentation comment will start with several tabs when it is meant to start with no tabs.
        /// Worse, any new lines in the comment will also be followed by several tab.
        /// </remarks>
        public IMemberElementXmlText RawFileFormatting =>
@"
        <member name=""M:R5T.T0211.Extensions.XElementExtensions.ToCElement(System.Xml.Linq.XElement)"">
            Somemore extra text.
            <inheritdoc cref=""M:R5T.T0211.Extensions.IXElementOperator.ToCElement(System.Xml.Linq.XElement)""/>
        </member>
"
// Do not trim.
.ToMemberElementXmlText();

        /// <summary>
        /// A member element that contains pathed self-referential crefs.
        /// </summary>
        public IMemberElementXmlText Self_Referential => Raw.R5T_Y0000_Glossary_ForIndex_Index;

    }
}
