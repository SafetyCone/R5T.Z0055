using System;


namespace R5T.Z0055
{
    public class MemberElementXmlTexts : IMemberElementXmlTexts
    {
        #region Infrastructure

        public static IMemberElementXmlTexts Instance { get; } = new MemberElementXmlTexts();


        private MemberElementXmlTexts()
        {
        }

        #endregion
    }
}
