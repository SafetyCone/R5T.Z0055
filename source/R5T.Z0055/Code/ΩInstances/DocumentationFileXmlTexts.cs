using System;


namespace R5T.Z0055
{
    public class DocumentationFileXmlTexts : IDocumentationFileXmlTexts
    {
        #region Infrastructure

        public static IDocumentationFileXmlTexts Instance { get; } = new DocumentationFileXmlTexts();


        private DocumentationFileXmlTexts()
        {
        }

        #endregion
    }
}
