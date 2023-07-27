using System;

using R5T.T0131;
using R5T.T0212;
using R5T.T0212.Extensions;


namespace R5T.Z0055.Raw
{
    /// <summary>
    /// Provides the XML-formatted texts of individual &lt;member&gt; elements in a .NET assembly XML documentation file.
    /// </summary>
    [ValuesMarker]
    public partial interface IMemberElementXmlTexts : IValuesMarker
    {
        /// <summary>
        /// Contains an inheritdoc element that self-references (by referencing it's parent).
        /// </summary>
        public IMemberElementXmlText Pathological_AX =>
@"
<member name=""P:R5T.S0082.Program.Pathological_AX"">
    <summary>
    Test Test Test <inheritdoc cref=""P:R5T.S0082.Program.A"" path=""/summary""/>
    </summary>
</member>
"
.Trim().ToMemberElementXmlText();

        /// <summary>
        /// Contains an inheritdoc element that self-references (by referencing it's parent).
        /// </summary>
        public IMemberElementXmlText Pathological_A =>
@"
<member name=""P:R5T.S0082.Program.Pathological_A"">
    <summary>
    Test <inheritdoc cref=""P:R5T.S0082.Program.Pathological_A"" path=""/summary""/>
    </summary>
</member>
"
.Trim().ToMemberElementXmlText();

        public IMemberElementXmlText R5T_S0082_Program_A =>
@"
<member name=""P:R5T.S0082.Program.A"">
    <summary>
    Test <inheritdoc cref=""P:R5T.S0082.Program.B"" path=""/summary""/>
    </summary>
</member>
"
.Trim().ToMemberElementXmlText();

        public IMemberElementXmlText R5T_S0082_Program_B =>
@"
<member name=""P:R5T.S0082.Program.B"">
    <summary>
    Test <inheritdoc cref=""P:R5T.S0082.Program.C"" path=""/summary""/>
    </summary>
</member>
"
.Trim().ToMemberElementXmlText();

        public IMemberElementXmlText R5T_S0082_Program_C =>
@"
<member name=""P:R5T.S0082.Program.C"">
    <summary>
    Test <inheritdoc cref=""P:R5T.S0082.Program.A"" path=""/summary""/>
    </summary>
</member>
"
.Trim().ToMemberElementXmlText();

        public IMemberElementXmlText R5T_Y0000_Glossary_ForIndex_Index =>
@"
<member name=""F:R5T.Y0000.Glossary.ForIndex.Index"">
<summary>
<inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.Index"" path=""/definition"" />
Indices are usually positive (greater than zero), but ranges can be constructed to have negative indices (less than zero).
Indices usually start at zero, but ranges can be constructed to start at indices both less than and greater than zero.
</summary>
<definition>An index is an integer that numerically indexes items in an ordered range from first to last.</definition>
<name><i>index</i></name>
</member>
"
.Trim().ToMemberElementXmlText();

        public IMemberElementXmlText R5T_Y0000_Glossary_ForIndex_Exclusive =>
@"
<member name=""F:R5T.Y0000.Glossary.ForIndex.Exclusive"">
<summary>
<inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.Exclusive"" path=""/definition"" />
A range begins at the index one after the first exclusive index, and stops at the index one before the last exclusive index.
<para><inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.ExclusiveInclusiveRelationship"" path=""/definition"" /></para>
</summary>
<definition>An exclusive index is not included in a range.</definition>
<name><i>exclusive</i></name>
</member>
"
.Trim().ToMemberElementXmlText();

        public IMemberElementXmlText R5T_Y0000_Glossary_ForIndex_Inclusive =>
@"
<member name=""F:R5T.Y0000.Glossary.ForIndex.Inclusive"">
<summary> 
<inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.Inclusive"" path=""/definition"" />
A range beings at the first inclusive index, and stops at the last the inclusive index.
<para><inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.ExclusiveInclusiveRelationship"" path=""/definition"" /></para>
</summary>
<definition>An inclusive index is included in a range.</definition>
<name><i>inclusive</i></name>
</member>
"
.Trim().ToMemberElementXmlText();

        public IMemberElementXmlText R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship =>
@"
<member name=""F:R5T.Y0000.Glossary.ForIndex.ExclusiveInclusiveRelationship"">
<summary>
<inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.ExclusiveInclusiveRelationship"" path=""/definition"" />
</summary>
<definition>The first <inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.Inclusive"" path=""/name"" /> index begins one after the first <inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.Exclusive"" path=""/name"" /> index, and the last <inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.Exclusive"" path=""/name"" /> index begins one after the last <inheritdoc cref=""F:R5T.Y0000.Glossary.ForIndex.Inclusive"" path=""/name"" /> index.</definition>
<name><i>exclusive-inclusive relationship</i></name>
</member>
"
.Trim().ToMemberElementXmlText();

    }
}
